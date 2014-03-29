function Module_Gameplay::Ass_Unload(%this)
{

AssetDatabase.releaseAsset(%this.Ass_Image_Rubberto_Duckie.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Goal.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Caustics.getAssetId());

AssetDatabase.releaseAsset(%this.Ass_Image_Water_Color.getAssetId());

}
