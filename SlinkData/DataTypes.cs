﻿namespace SlinkData {

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

   public class PersonExt {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Phonenumber { get; set; }
      public string Mail { get; set; }
      public string Comment { get; set; }
      public string Link { get; set; }
      public string Occupy1 { get; set; }
      public string Occupy2 { get; set; }

      public PersonExt(int id, string name, string phonenumber, string mail,string comment, string link, string occupy1, string occupy2) {
         Id = id;
         Name = name;
         Phonenumber = phonenumber;
         Mail = mail;
         Comment = comment;
         Link = link;
         Occupy1 = occupy1;
         Occupy2 = occupy2;
      }
   }

   public class PersonRaw {
      public int Id { get; set; }
      public string Forename { get; set; }
      public string Surname { get; set; }
      public string Alias { get; set; }
      public string Phonenumber { get; set; }
      public string Mail { get; set; }
      public string Comment { get; set; }
      public int Link { get; set; }
      public int Occupy1 { get; set; }
      public int Occupy2 { get; set; }

      public PersonRaw(int id, string forename, string surname, string alias, string phonenumber, string mail, string comment, int link, int occupy1, int occupy2) {
         Id = id;
         Forename = forename;
         Surname = surname;
         Alias = alias;
         Phonenumber = phonenumber;
         Mail = mail;
         Comment = comment;
         Link = link;
         Occupy1 = occupy1;
         Occupy2 = occupy2;
      }

   }

   public class Festival {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Town { get; set; }
      public string Link { get; set; }
      public string Mail { get; set; }
      public string Start { get; set; }
      public string Deadline { get; set; }
      public string Manager { get; set; }
      public string Rank { get; set; }
      public string Comment { get; set; }

      public Festival(int id, string name, string town, string link, string mail, string start, string deadline, string manager, string rank, string comment) {
         Id = id;
         Name = name;
         Town = town;
         Link = link;
         Mail = mail;
         Start = start;
         Deadline = deadline;
         Manager = manager;
         Rank = rank;
         Comment = comment;
      }
   }

   public class FestivalRaw {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Town { set; get; }
      public int Link { set; get; }
      public string Mail { set; get; }
      public string Start { get; set; }
      public string Deadline { get; set; }
      public int Manager { get; set; }
      public int Rank { get; set; }
      public string Comment { get; set; }

      public FestivalRaw(int id, string name, int town, int link, string mail, string start, string deadline, int manager, int rank, string comment) {
         Id = id;
         Name = name;
         Town = town;
         Link = link;
         Mail = mail;
         Start = start;
         Deadline = deadline;
         Manager = manager;
         Rank = rank;
         Comment = comment;
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

   public class TownExt {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Distance { get; set; }
      public string Size { get; set; }

      public TownExt(int id, string name, int distance, string size) {
         Id = id;
         Name = name;
         Distance = distance;
         Size = size;
      }

      public override string ToString() {
         return Name;
      }
   }

   public class TownRaw {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Distance { get; set; }
      public int Size { get; set; }
      public string Comment { get; set; }

      public TownRaw(int id, string name, int distance, int size, string comment) {
         Id = id;
         Name = name;
         Distance = distance;
         Size = size;
         Comment = comment;
      }

   }

   public class Pub {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Town { get; set; }
      public string Rank { get; set; }
      public string Manager { get; set; }
      public string Mail { get; set; }
      public string Link { get; set; }
      public string Comment { get; set; }


      public Pub(int id, string name, string town, string rank, string manager, string mail, string link, string comment) {
         Id = id;
         Name = name;
         Town = town;
         Rank = rank;
         Manager = manager;
         Mail = mail;
         Link = link;
         Comment = comment;
      }
   }

   public class PubRaw {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Town { get; set; }
      public int Rank { get; set; }
      public int Manager { get; set; }
      public string Mail { get; set; }
      public int Link { get; set; }
      public string Comment { get; set; }


      public PubRaw(int id, string name, int town, int rank, int manager, string mail, int link, string comment) {
         Id = id;
         Name = name;
         Town = town;
         Rank = rank;
         Manager = manager;
         Mail = mail;
         Link = link;
         Comment = comment;
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

   public class LinkRaw {
      public int Id { get; set; }
      public int LinkType { get; set; }
      public string Url { get; set; }
      public string Comment { get; set; }

      public LinkRaw(int id, int linkType, string url, string comment) {
         Id = id;
         LinkType = linkType;
         Url = url;
         Comment = comment;
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