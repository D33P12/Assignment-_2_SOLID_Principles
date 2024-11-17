public interface IScoreSystem
{ 
    //Interface Segregation: Provides a specific interface for score-related functionalities.
    // Dependency Inversion: needing score functionality from game manager.
    void AddScore(int amount);
    int GetScore();
}