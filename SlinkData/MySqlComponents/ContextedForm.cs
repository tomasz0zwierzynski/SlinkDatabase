using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlinkData {
   public class ContextedForm : Form {

      protected MySqlContext context;

      public int Return { get; set; }
      public long LastInsertId { get; set; }

      public ContextedForm(MySqlContext context) : base(){
         this.context = context;
         Return = -1;
      }

      public ContextedForm() : base() {
         //To enable C# designer
      }

   }
}
