terraform {
  required_version = ">= 1.0"
  required_providers {
    azurerm = {
      source  = "registry.opentofu.org/hashicorp/azurerm"
      version = "~> 3.0"
    }
    azapi = {
      source  = "registry.opentofu.org/Azure/azapi"
      version = "~> 1.0"
    }
  }
}

provider "azurerm" {
  features {}
}