using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFormHomeCalc.Interfaces;

namespace WFormHomeCalc
{
    public class Calc
    {
        private IList<IOperation> operations { get; set; }

        public Calc()
        {
            operations = new List<IOperation>();

            var asm = Assembly.GetExecutingAssembly();
            var typeOperation = typeof(IOperation);

            LoadOperations(asm, typeOperation);

            var path = AppDomain.CurrentDomain.BaseDirectory + "\\Extensions";
            var files = Directory.GetFiles( path, "*.dll");

            foreach (var file in files)
            {
                try
                {
                    LoadOperations(Assembly.LoadFile(file), typeOperation);
                }
                catch { }
            }            
        }

        public void LoadOperations(Assembly asm, Type typeOperation)
        {
            var types = asm.GetTypes();
            
            foreach (var type in types.Where(t => !t.IsAbstract && !t.IsInterface))
            {
                if (type.GetInterfaces().Any(t => t == typeOperation))
                {
                    var obj = Activator.CreateInstance(type);

                    var operation = obj as IOperation;

                    if (operation != null)
                    {
                        operations.Add(operation);
                    }
                }
            }
        }

        public string[] GetOperationsName()
        {
            return operations.Select(o => o.Name).ToArray();
        }

        public double Exec(string name, double[] args)
        {
            var oper = operations.FirstOrDefault(o => o.Name == name);

            if (oper == null)
            {
                return double.NaN;
            }

            return oper.Exec(args); 
        }

    }
}
