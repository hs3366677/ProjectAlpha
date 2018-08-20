using UnityEngine;

namespace TowerDefense.UI.HUD
{
	/// <summary>
	/// States the placement tile can be in
	/// </summary>
	public enum PlacementTileState
	{
		Filled,
		Empty
	}
	
	/// <summary>
	/// Simple class to illustrate tile placement locations
	/// </summary>
	public class PlacementTile : MonoBehaviour
	{
	    /// <summary>
	    /// Material to use when this tile is empty
	    /// </summary>
	    public Sprite emptySprite;
	    /// <summary>
	    /// Material to use when this tile is filled
	    /// </summary>
	    public Sprite filledSprite;

        /// <summary>
        /// The renderer whose material we're changing
        /// </summary>
        public SpriteRenderer tileRenderer;

		/// <summary>
		/// Update the state of this placement tile
		/// </summary>
		public void SetState(PlacementTileState newState)
		{
			switch (newState)
			{
				case PlacementTileState.Filled:
					if (tileRenderer != null && filledSprite != null)
					{
						tileRenderer.sprite = filledSprite;
					    tileRenderer.drawMode = SpriteDrawMode.Simple;
					}
					break;
				case PlacementTileState.Empty:
					if (tileRenderer != null && emptySprite != null)
					{
						tileRenderer.sprite = emptySprite;
					    tileRenderer.drawMode = SpriteDrawMode.Tiled;
					}
					break;
			}
		}

	    public void SetDimension(int width, int height)
	    {
	        if (tileRenderer == null)
	            return;
	        if (tileRenderer.drawMode == SpriteDrawMode.Simple)
	            return;
            tileRenderer.size = new Vector2(width, height);
	    }
	}
}