using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoSimProjectPP
{
    abstract class Detail : Traits, IItem
    {
        public int DetailStatePoints { get; protected set; }
        public bool IsDestroyed { get; protected set; } = false;
        public Ship? OwnerShip { get; protected set; }
        public virtual void OnDamage(int damagePoints)
        {
            DetailStatePoints -= damagePoints;
            IsDestroyed = DetailStatePoints <= 0;
        }
        protected virtual void OnDestruction()
        {

        }
    }
    abstract class Engine : Detail
    {
        public int EnginePower { get; protected set; }
        protected FuelTank Tank { get; set; }
        public virtual void Warp()
        {

        }
        public virtual void Move(int xAxis, int yAxis)
        {

        }
    }
    abstract class Weapon : Detail
    {
        public int WeaponDMG { get; protected set; } = 1;
        public virtual void Shoot(int xAxis, int yAxis)
        {

        } 
    }
    abstract class Radar : Detail
    {
        public int ScanRadius { get; protected set; }
        public virtual void Scan(int xAxis, int yAxis)
        {

        }
    }
    class Storage : Detail
    {
        public int MaxWeight { get; private set; }
        public int MaxCapacity { get; private set; }
        public int CurrentWeight { get; private set; }
        public int CurrentCapacity { get; private set; }
        public List<IItem> ItemList;
        public void Store(IItem item)
        {

        }
        
    }
    abstract class Equipment : Detail
    {
        public virtual void Work(int xAxis, int yAxis)
        {

        }
    }
    abstract class Armor : Detail
    {
        public int MaxDmg { get; protected set; }
        public int CurrentDmg { get; protected set; }
        public override void OnDamage(int damagePoints)
        {
            base.OnDamage(damagePoints);
        }
    }
    class FuelTank : Detail
    {
        public int MaxCapacity { get; protected set; }
        public int CurrentCapacity { get; protected set; }
        public void Fill(int fuelCapacity)
        {

        }
    }
    class Ship
    {
        protected Engine ShipEngine;
        protected FuelTank ShipFuelTank;
        protected Storage ShipStorage;
        protected Equipment ShipEquipment;
        protected Radar ShipRadar;
        protected Weapon ShipWeapon;
        protected Armor ShipArmor;

        public void SwapParts(Detail part1, Detail part2)
        {

        }
    }
}
