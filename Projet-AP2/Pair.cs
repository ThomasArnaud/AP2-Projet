using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_AP2
{
    class Pair<M, N>
    {
        /// <summary>
        /// Represents the first item of the pair.
        /// </summary>
        protected M first;

        /// <summary>
        /// Accesor and mutator for the first item of the pair.
        /// </summary>
        public M First
        {
            get
            {
                return this.first;
            }

            set
            {
                this.first = value;
            }
        }

        /// <summary>
        /// Represents the second item of the pair.
        /// </summary>
        protected N second;

        /// <summary>
        /// Accessor and mutator for the second item of the pair.
        /// </summary>
        public N Second
        {
            get
            {
                return this.second;
            }

            set
            {
                this.second = value;
            }
        }

        /// <summary>
        /// Creates a new pair.
        /// </summary>
        /// <param name="first">Reference to the first item of the pair.</param>
        /// <param name="second">Reference to the second item of the pair.</param>
        public Pair(M first, N second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
