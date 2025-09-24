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

output "azure_static_web_app_api_token" {
  description = "Azure Static Web App API deployment token"
  value       = azurerm_static_web_app.main.api_key
  sensitive   = true
}

output "static_web_app_url" {
  description = "Azure Static Web App default hostname"
  value       = "https://${azurerm_static_web_app.main.default_host_name}"
}

output "deployment_environment" {
  description = "Deployment environment name"
  value       = terraform.workspace
}

output "resource_group_name" {
  description = "Resource group name"
  value       = azurerm_resource_group.main.name
}
