using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParcialScripting
{
    class SearchPath
    {
        private Node _startingPoint;
        private Node _endingPoint;
        private Dictionary<int, Node> _block = new Dictionary<int, Node>();
        private Queue<Node> _queue = new Queue<Node>();
        private List<Node> _path = new List<Node>();
        public List<Node> Path
        {
            get
            {
                if (_path.Count == 0)                           // If we've already found path, no need to check it again
                {
                    //LoadAllBlocks();
                    //BFS();
                    //CreatePath();
                }
                return _path;
            }
        }







    }

 
}
    