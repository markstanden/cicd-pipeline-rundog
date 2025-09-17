resource "azurerm_static_web_app" "main" {
  name                = "${var.static_web_app}-${var.app_code}-${terraform.workspace}-${var.azure_region.code}"
  resource_group_name = azurerm_resource_group.main.name
  location            = azurerm_resource_group.main.location
  sku_tier            = var.swa_sku.tier
  sku_size            = var.swa_sku.size
  
  tags = merge(var.app_tags, {
    Environment = terraform.workspace
    Workspace   = terraform.workspace
  })
}

resource "azapi_update_resource" "appsettings" {
  type      = "Microsoft.Web/staticSites/config@2024-11-01"
  name      = "appsettings"
  parent_id = azurerm_static_web_app.main.id

  body = {
    properties = {
      BUILD_ENVIRONMENT = terraform.workspace
    }
  }
}

output "azure_static_web_app_api_token" {
  description = "Azure Static Web App API deployment token"
  value       = azurerm_static_web_app.main.api_key
  sensitive   = true
}
