using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCalc
{
    class InputHandle
    {
        private static InputHandle inst = null;

        private String input = "5+6*(4*3+(3+2))";
        private String solution = "";

        private InputHandle()
        { }

        public static InputHandle getInputHandleInstance()
        {
            if(inst==null)
            {
                inst = new InputHandle();
            }
            return inst;
        }

        public void appendInput(String input_in)
        {
            input+=input_in;
        }

        public void removeInput()
        {
            try
            {
                input = input.Remove(input.Length - 1);
            }
            catch(Exception e)
            {}
        }

        public String getInputText()
        {
            return input;
        }

        public void setSolution(String solution_in)
        {
            solution = solution_in;
        }

        public String getSolution()
        {
            return solution;
        }
    }
}
