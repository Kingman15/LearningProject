namespace LearningProject.DAL.Entity
{
    public partial class UnitOfMeasure
    {
        public override string ToString()
        {
            return this.shortName;
        }

        public override bool Equals(object obj)
        {
            if (obj is UnitOfMeasure other)
            {
                return this.id == other.id; 
            }
            return false; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
