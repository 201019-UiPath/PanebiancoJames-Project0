namespace GameKingdomLib
{
    /// <summary>
    /// Manager model
    /// </summary>
    public class Manager
    {
        
        /// <summary>
        /// Auto prop for ManagerId
        /// </summary>
        /// <value></value>
        public string ManagerId {get; set; }

        /// <summary>
        /// Manager constructor
        /// </summary>
        /// <param name="managerId"></param>
        /// <param name="location"></param>
        public Manager(string managerId, Location location)
        {
            ManagerId = managerId;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Manager()
        {

        }
    }
}