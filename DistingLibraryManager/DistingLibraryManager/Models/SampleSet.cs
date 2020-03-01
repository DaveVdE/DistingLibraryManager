using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistingLibraryManager.Models
{
    /// <summary>
    /// Represents a set of samples and the options used when reading or writing to the playlist format.
    /// </summary>
    public class SampleSet
    {
        /// <summary>
        /// The path from which the playlist was read, or to which the playlist and samples will be written.
        /// </summary>
        public string Path { get; set; }

        public List<Sample> Samples { get; set; }
    }
}
