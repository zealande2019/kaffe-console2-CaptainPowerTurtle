using System.Buffers.Text;
using System.Runtime.CompilerServices;
using kaffe;

namespace KaffeConsoleAppNetCore
{
    public class FlatWhite : Kaffe, Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal bruges til Latte
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        public override int Pris()
        {
            return 45;
        }

        public override string Styrke()
        {
            return "Mild";
        }

        public FlatWhite(int rabat) : base(rabat)
        {
        }

    }
}