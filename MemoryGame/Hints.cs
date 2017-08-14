using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public class Hints
    {
        Stack<string> hints = new Stack<string>();


        public Hints()
        {
            //Good Hints
            hints.Push("Keep Continuing");
            hints.Push("Oh it Seems You are doing a Nice Job");
            hints.Push("Oh Amazing");
            hints.Push("Keep Discovering Cards");
            hints.Push("Excelent Job");
            hints.Push("Good Memory");
            hints.Push("Amazing Job");

        }

        public void GetHint()
        {
            if (hints.Count != 0)
            {
                MessageBox.Show(hints.Peek());
                hints.Pop();
            }
            else
            {
                MessageBox.Show("No more hints left!");
            }

        }
    }

    public class AdapterHints : Hints, IHints
    {
        public void GetHints()
        {
            this.GetHint();
        }
    }

    public interface IHints
    {
        void GetHints();
    }

}
