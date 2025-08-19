resource "azurerm_static_site" "main" {
  name                = "${var.static_web_app}-${var.app_code}-${terraform.workspace}-${var.azure_region.code}"
  resource_group_name = azurerm_resource_group.main.name
  location            = azurerm_resource_group.main.location
  sku_tier            = var.swa_sku.tier
  sku_size            = var.swa_sku.size
  tags = merge(var.app_tags, {
    Environment = terraform.workspace
    Workspace = terraform.workspace
  })
}