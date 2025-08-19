resource "azurerm_resource_group" "main" {
  name     = "${var.resource_group}-${var.app_code}-${terraform.workspace}-${var.azure_region.code}"
  location = var.azure_region.location
  tags = merge(var.app_tags, {
    Environment = terraform.workspace
    Workspace   = terraform.workspace
  })
}