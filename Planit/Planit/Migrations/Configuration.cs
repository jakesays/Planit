namespace Planit.Migrations
{
    using Planit.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Planit.Models.ProjectDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Planit.Models.ProjectDBContext";
        }

        protected override void Seed(Planit.Models.ProjectDBContext context)
        {
            Project school = new Project{   ID = 0001, UserID = "9999", Depth = 1, 
                                            ParentID = "0000", Description = "School", 
                                            DueDate =   new DateTime(2014, 5, 15),
                                            StartDate = new DateTime(2014, 2, 25)};

                Project CSC201j = new Project{  ID = 0004, UserID = "9999", Depth = 2, 
                                                ParentID = "0001", Description = "CSC201j", 
                                                DueDate = new DateTime(2013, 5, 15),
                                                StartDate = new DateTime( 2013, 2, 25)};

                    Project Labs = new Project{ ID = 0008, UserID = "9999", Depth = 3, 
                                                ParentID = "0004", Description = "Labs", 
                                                DueDate = new DateTime(2013, 5, 15),
                                                StartDate = new DateTime( 2013, 2, 25)};

                        Project Lab_01 = new Project{  ID = 0015, UserID = "9999", Depth = 4, 
                                                    ParentID = "0008", Description = "Lab 01", 
                                                    DueDate = new DateTime(2013, 3, 1),
                                                    StartDate = new DateTime( 2013, 2, 25)};
                        
                        Project Lab_02 = new Project{  ID = 0016, UserID = "9999", Depth = 4, 
                                                    ParentID = "0008", Description = "Lab 02", 
                                                    DueDate = new DateTime(2013, 4, 1),
                                                    StartDate = new DateTime( 2013, 2, 25)};

                        Project Lab_03 = new Project{  ID = 0017, UserID = "9999", Depth = 4, 
                                                    ParentID = "0008", Description = "Lab 03", 
                                                    DueDate = new DateTime(2013, 5, 1),
                                                    StartDate = new DateTime( 2013, 2, 25)};

                    Project Reading = new Project{   ID = 0009, UserID = "8888", Depth = 3, 
                                                    ParentID = "0004", Description = "Reading", 
                                                    DueDate = new DateTime(2013, 5, 15),
                                                    StartDate = new DateTime( 2013, 2, 25)};

                Project MAT220 = new Project{   ID = 0005, UserID = "9999", Depth = 2, 
                                            ParentID = "0001", Description = "MAT220", 
                                            DueDate = new DateTime(2013, 5, 15),
                                            StartDate = new DateTime( 2013, 2, 25)};
                    
                    Project Homework = new Project{  ID = 0010, UserID = "9999", Depth = 3, 
                                                    ParentID = "0005", Description = "Homework", 
                                                    DueDate = new DateTime(2013, 5, 15),
                                                    StartDate = new DateTime( 2013, 2, 25)};


            Project chores = new Project{   ID = 0002, UserID = "9999", Depth = 1, 
                                            ParentID = "0000", Description = "Chores", 
                                            DueDate =   new DateTime(2015, 1, 1),
                                            StartDate = new DateTime( 2014, 2, 25)};
                
                Project Gardening = new Project{   ID = 0006, UserID = "9999", Depth = 2, 
                                                ParentID = "0002", Description = "Gardening", 
                                                DueDate = new DateTime(2013, 6, 15),
                                                StartDate = new DateTime( 2013, 4, 1)};

                    Project Get_Materials = new Project{  ID = 0011, UserID = "9999", Depth = 3, 
                                                    ParentID = "0006", Description = "Get Materials", 
                                                    DueDate = new DateTime(2013, 4, 7),
                                                    StartDate = new DateTime( 2013, 4, 1)};

                    Project Prep_Beds = new Project{  ID = 0012, UserID = "9999", Depth = 3, 
                                                    ParentID = "0006", Description = "Prep Beds", 
                                                    DueDate = new DateTime(2013, 4, 14),
                                                    StartDate = new DateTime( 2013, 4, 7)};

                    Project Plant = new Project{    ID = 0013, UserID = "9999", Depth = 3, 
                                                    ParentID = "0006", Description = "Plant", 
                                                    DueDate = new DateTime(2013, 5, 01),
                                                    StartDate = new DateTime(2013, 5, 01)};

                    Project Mulch = new Project{  ID = 0014, UserID = "9999", Depth = 3, 
                                                    ParentID = "0006", Description = "Mulch", 
                                                    DueDate = new DateTime(2013, 5, 14),
                                                    StartDate = new DateTime( 2013, 5, 7)};


            Project work = new Project{   ID = 0003, UserID = "9999", Depth = 1, 
                                            ParentID = "0000", Description = "Work", 
                                            DueDate =   new DateTime(2015, 1, 1),
                                            StartDate = new DateTime( 2014, 2, 25)};

                Project InventorySystem = new Project{   ID = 0007, UserID = "9999", Depth = 2, 
                                                ParentID = "0003", Description = "InventorySystem", 
                                                DueDate = new DateTime(2013, 4, 1),
                                                StartDate = new DateTime( 2013, 2, 25)};

            context.Projects.AddOrUpdate(   p => p.Description,
                                            school, CSC201j, Labs, Lab_01,
                                            Lab_02, Lab_02, Lab_03, Reading,
                                            MAT220, Homework, chores, Gardening, 
                                            Get_Materials, Prep_Beds, Plant, Mulch, 
                                            work, InventorySystem);
        }
    }
}
