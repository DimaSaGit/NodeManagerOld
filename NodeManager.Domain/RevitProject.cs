using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    class RevitProject
    {
		//public int ID;
		public string Name { get; set; }
		public string FilePath { get; set; }
		public int NumberOfSaves { get; set; }
		public string Tags { get; set; }

		public RevitProject()
        {}
		public RevitProject(string name, string filePath, int numberOfSaves, string tags)
		{
			//ID = id;
			Name = name;
			FilePath = filePath;
			NumberOfSaves = numberOfSaves;
			Tags = tags;
		}
	}

	class RevitView
	{
		public int ID;
		public int? ProjectID;
		public string Name;
		public string ImagePath;
		public int Scale;
		public RevitProject RevProj;


		public RevitView()
        {}
		public RevitView(int id, string name, int scale, RevitProject rp)
		{
			ID = id;
			//ProjectID = projectID;
			Name = name;
			//ImagePath = imagePath;
			Scale = scale;
			RevProj = rp;
		}
	}

	class RevitParameterOld
	{
		//public int ID;
		public int? ViewID;
		public string Name;
		public string Value;
		public int StorageType;
		public RevitView RevView;

		public RevitParameterOld() { }
        

		public RevitParameterOld(int viewID, string name, string value, int storageType)
		{
			//ID = id;
			ViewID = viewID;
			Name = name;
			Value = value;
			StorageType = storageType;
		}
	}
}
