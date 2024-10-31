using LearningProject.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.DAL.Manager
{
    public static class DbManager
    {
        #region unitOfMesure 

        public static List<UnitOfMeasure> GetUnitOfMeasures()
        {
            var unitsOfMesure = new List<UnitOfMeasure>();

            try
            {
                using (var context = new ModelDB())
                {
                    unitsOfMesure = context.UnitOfMeasures
                        .OrderBy(uom => uom.shortName)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                // ...
            }

            return unitsOfMesure;
        }

        #endregion

        #region foodItem

        public static List<FoodItem> GetFoodItems()
        {
            var foodItems = new List<FoodItem>();

            try
            {
                using (var context = new ModelDB())
                {
                    foodItems = context.FoodItems
                        .Include(fi => fi.UnitOfMeasure)
                        .OrderBy(fi => fi.name)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                // ...
            }

            return foodItems;
        }

        public static bool InsertFoodItem(string _name, long? _uomId, string _description, decimal _alertThreshold, string _category)
        {
            try
            {
                using (var context = new ModelDB())
                using (var transaction = context.Database.BeginTransaction())
                {
                    // check if name exists TODO

                    if (_uomId != null && _uomId.Value <= 0)
                        _uomId = null;

                    var foodItem = new FoodItem()
                    {
                        name = _name,
                        unitOfMeasureId = _uomId,
                        description = _description,
                        stockQuantity = 0,
                        alertThreshold = _alertThreshold,
                        category = _category,
                        createdAt = DateTime.Now // Server datetime TODO
                    }; 
                    context.FoodItems.Add(foodItem);
                    context.SaveChanges();

                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // ...TODO
            }

            return false;
        }

        public static bool UpdateFoodItem(long _itemId, string _name, long? _uomId, string _description, decimal _alertThreshold, string _category)
        {
            try
            {
                using (var context = new ModelDB())
                using (var transaction = context.Database.BeginTransaction())
                {
                    var foodItem = context.FoodItems.SingleOrDefault(f => f.id == _itemId);
                    if (foodItem == null)
                    {
                        // TODO
                        return false;
                    }

                    if (_uomId != null && _uomId.Value <= 0)
                        _uomId = null;

                    foodItem.name = _name;
                    foodItem.unitOfMeasureId = _uomId;
                    foodItem.description = _description;
                    foodItem.alertThreshold = _alertThreshold;
                    foodItem.category = _category;
                    foodItem.updatedAt = DateTime.Now; // TODO

                    context.SaveChanges();
                    transaction.Commit();

                    return true;
                }
            }
            catch (Exception ex)
            {
                // TODO (log)
                return false;
            }
        }

        public static bool DeleteFoodItem(long _itemId)
        {
            try
            {
                using (var context = new ModelDB())
                using (var transaction = context.Database.BeginTransaction())
                {
                    FoodItem foodItem = context.FoodItems.Find(_itemId);
                    if (foodItem == null)
                    {
                        // ...
                    }

                    context.FoodItems.Remove(foodItem);
                    context.SaveChanges();

                    // TODO : log

                    transaction.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // ... TODO
            }

            return false;
        }

        #endregion

        #region stockEntryDetail 

        public static List<StockEntryDetail> GetStockEntryDetails(long? _foodItemId = null, bool? _onlyInStock = null)
        {
            var details = new List<StockEntryDetail>();

            try
            {
                using (var context = new ModelDB())
                {
                    var query = context.StockEntryDetails
                        .Include(sed => sed.StockEntry)
                        .Include(sed => sed.FoodItem)
                        .AsQueryable();

                    if (_foodItemId.HasValue && _foodItemId.Value > 0)
                    {
                        query = query.Where(sed => sed.foodItemId == _foodItemId.Value);
                    }
                    if (_onlyInStock.HasValue && _onlyInStock.Value == true)
                    {
                        query = query.Where(sed => sed.currentQuantity > 0);
                    }

                    details = query
                        .OrderBy(sed => sed.FoodItem.name)
                        .ThenByDescending(sed => sed.StockEntry.entryDate)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                // ... TODO
            }

            return details;
        }

        #endregion
    }
}
