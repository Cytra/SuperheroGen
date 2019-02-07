using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroGen.Models
{
    /// <summary>
    /// Person object
    /// </summary>
    public class Person
    {
        /// <summary>
        /// First name of the Person object
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of the person object
        /// </summary>
        [Required]
        public string LastName { get; set; }

        private string _heroName;
        /// <summary>
        /// SuperHero name
        /// </summary>
        
        public string  HeroName
        {
            get { return _heroName; }
        }

        public void SetHeroName()
        {
            _heroName = "Batman";
        }
    }
}
