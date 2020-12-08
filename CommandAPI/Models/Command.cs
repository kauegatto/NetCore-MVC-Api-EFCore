using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommandAPI.Models{
    public class Command{
        #region constructors
        public Command(string _howTo, string _platform, string _commandLine){
            this.howTo = _howTo;
            this.platform = _platform;
            this.commandLine = _commandLine;
        
        }
        public Command(){
        }
        
        #endregion
        public int id {get;set;}

        [Column("ds_commandLine")]
        [Required]
        public string commandLine{get;set;}

        [Column("ds_howTo")]
        public string howTo{get;set;}
        
        [Column("nm_platform")]
        public string platform{get;set;}

        [Column("ds_whatItDoes")]
        public string whatItDoes {get;set;}
    }
}