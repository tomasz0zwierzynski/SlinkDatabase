namespace SlinkData {

   public class Rank {
      public int Id { get; set; }
      public string RankName { get; set; }
      public int RankValue { get; set; }
      public string Comment { get; set; }

      public Rank(int id, string rankName, int rankValue, string comment) {
         Id = id;
         RankName = rankName;
         RankValue = rankValue;
         Comment = comment;
      }

      public override string ToString() {
         return RankName + " - " + RankValue + " - " + Comment;
      }

   }
   public class Person {
      public int Id { get; set; }
      public string Forename { get; set; }
      public string Surname { get; set; }
      public string Alias { get; set; }
      public string Comment { get; set; }

      public Person(int id, string forename, string surname, string alias, string comment) {
         Id = id;
         Forename = forename;
         Surname = surname;
         Alias = alias;
         Comment = comment;
      }

      public override string ToString() {
         string value = "";
         if (Forename != "") {
            value += Forename + " ";
         }
         if (Alias != "") {
            value += "\"" + Alias + "\" ";
         }
         if (Surname != "") {
            value += Surname + " ";
         }
         if (Comment != "") {
            value += ": " + Comment;
         }

         return value;
      }

   }

   public class Town {
      public int Id { get; set; }
      public string Name { get; set; }

      public Town(int id, string name) {
         Id = id;
         Name = name;
      }

      public override string ToString() {
         return Name;
      }
   }

   public class Link {
      public int Id { get; set; }
      public string LinkType { get; set; }
      public string Url { get; set; }
      public string Comment { get; set; }

      public Link(int id, string linkType, string url, string comment) {
         Id = id;
         LinkType = linkType;
         Url = url;
         Comment = comment;
      }

      public override string ToString() {
         if (Comment == "") {
            return LinkType + ": " + Url;
         }
         else {
            return LinkType + ", " + Comment + ": " + Url;
         }

      }
   }

   public class Occupation {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }

      public Occupation(int id, string name, string description) {
         Id = id;
         Name = name;
         Description = description;
      }

      public override string ToString() {
         if (Description == "") {
            return Name;
         }
         else {
            return Name + ": " + Description;
         }
      }
   }

   public class LinkType {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }

      public LinkType(int id, string name, string description) {
         Id = id;
         Name = name;
         Description = description;
      }

      public override string ToString() {
         if (Description == "") {
            return Name;
         }
         else {
            return Name + ": " + Description;
         }

      }
   }

   public class TownSize {
      public int Id { get; set; }
      public string SizeName { get; set; }
      public int LowerLimit { get; set; }
      public int UpperLimit { get; set; }
      public string Comment { get; set; }

      public TownSize(int id, string sizeName, int lowerLimit, int upperLimit, string comment) {
         Id = id;
         SizeName = sizeName;
         LowerLimit = lowerLimit;
         UpperLimit = upperLimit;
         Comment = comment;
      }

      public override string ToString() {
         if (Comment == "") {
            return SizeName + " ( " + LowerLimit + " - " + UpperLimit + " )";
         }
         else {
            return SizeName + " ( " + LowerLimit + " - " + UpperLimit + " ) :" + Comment;
         }

      }
   }
}