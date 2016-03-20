using FATEC.ArcadeSpaceBattle.Objects;
using UnityEngine;
namespace FATEC.ArcadeSpaceBattle.Abstractions {
    /// <summary>
    /// Represents a gun that shoots things
    /// </summary>
    public interface IGun {
        /// <summary>
        /// shoot a projectile or other thing 
        /// </summary>
        GameObject Shoot();
    }
}