namespace Assets.Codebase.Models.Base
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            InitModel();
        }

        protected abstract void InitModel();
    }
}
