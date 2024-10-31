namespace LearningProject.DAL.Entity
{
    public partial class FoodItem
    {
        public string UnitOfMesureStr => this.UnitOfMeasure?.shortName ?? "N/A";
    }
}
