using UnityEngine;

//Variables used my multiple scripts, but aren't saved between sessions
public static class Global {
  // Current player
  public static GameObject _Player;

  public static Vector3 _CurrentSpawn;


  #region coins

  //Coins that were collected in the current level and will be lost upon death
  public static int _RoundCoins;

  public static void StoreCoins (int amount) {
    amount = _RoundCoins < 0 ? _RoundCoins : amount;
    PlayerStats._SecuredCoins += amount;
    _RoundCoins -= amount;
  }
  public static int GetTotalCoins () => PlayerStats._SecuredCoins + _RoundCoins;

  #endregion
}