namespace CommandAPI.Models{
    public class Command{
        #region constructors

        public Command(string _howTo, string _platform, string _commandLine){
            this.ds_howTo = _howTo;
            this.nm_platform = _platform;
            this.ds_commandLine = _commandLine;
        }
        public Command(){
        }
        #endregion
        public int id {get;set;}
        public string ds_howTo{get;set;}
        public string nm_platform{get;set;}
        public string ds_commandLine{get;set;}
        
    }
}