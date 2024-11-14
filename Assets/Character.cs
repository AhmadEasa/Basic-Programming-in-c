using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    class Character
    {
        public string Name;
        private int health;
        protected Position position;

        public int Health
        {
            get => health;
            set => health = Mathf.Clamp(value, 0, 100);
        }

        public Character(string name, int health, Position position)
        {
            Name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Character Info -> Name: {Name}, Health: {Health}");
            position.PrintPosition();
        }

        private void ApplyDamage(int damage, Character target)
        {
            target.Health -= damage;
        }

        public void Attack(int damage, Character target)
        {
            ApplyDamage(damage, target);
        }

        public void Attack(int damage, Character target, string attackType)
        {
            ApplyDamage(damage, target);
            Debug.Log($"{Name} performed {attackType} on {target.Name}, dealing {damage} damage.");
        }
    }
}
