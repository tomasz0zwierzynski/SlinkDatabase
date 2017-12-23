using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlinkData {
   static class GenericForm {
      
      // Method Showing Modal Form of T_FormClass type and as in this form
      // important data has accepted, gets new data from database, by calling
      // function "Read" in class T_GetClass and dumping it into combobox as
      // objects of class T_CBobject.
      public static void ShowForm<T_CBobject,T_FormClass, T_GetClass>(MySqlContext context, List<T_CBobject> list, ComboBox comboBox)
                           where T_FormClass : ContextedForm
                           where T_CBobject : IdHaving {
         T_FormClass form = (T_FormClass)Activator.CreateInstance(typeof(T_FormClass), context);
         form.ShowDialog();
         long townId = form.LastInsertId;
         int respond = form.Return;
         form.Dispose();

         if (respond == 1 || respond == 2) {
            list = (List<T_CBobject>) typeof(T_GetClass).GetMethod("Read").Invoke(null, new object[] { context, false });
            var LastAddedLink = list.OrderByDescending(item => item.Id).First();    //used to select just added item
            comboBox.Items.Clear();
            foreach (object obj in list) {
               comboBox.Items.Add(obj);
            }
            comboBox.SelectedItem = LastAddedLink;
         }

      }
      
      public static void FillComboBox<T_CBobject>(ComboBox target,List<T_CBobject> collection,bool selectZeroIndex) {
         foreach (T_CBobject obj in collection) {
            target.Items.Add(obj);
         }
         if (selectZeroIndex) {
            if (target.Items.Count != 0) {
               target.SelectedIndex = 0;
            }
         }
      }

      public static void FillComboBox<T_CBobject>(ComboBox target, List<T_CBobject> collection, int selectionObjectIndex)
                        where T_CBobject : IdHaving {
         T_CBobject currentLinkType = null;
         foreach (T_CBobject obj in collection) {
            target.Items.Add(obj);
            if (obj.Id == selectionObjectIndex) {
               currentLinkType = obj;
            }
         }
         if (currentLinkType != null) {
            target.SelectedIndex = target.Items.IndexOf(currentLinkType);
         }
      }

   }
}
