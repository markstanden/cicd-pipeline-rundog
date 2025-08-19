variable "app_code" {
  description = "Name of the application within the resource name"
  type        = string
  default     = "rrd"
}

variable "azure_region" {
  description = "Azure region"
  type = object({
    location = string
    code     = string
  })
  default = {
    location = "UK South",
    code     = "uks"
  }
}

variable "app_tags" {
  description = "Tags to apply to all resources"
  type = object({
    Project   = string
    ManagedBy = string
  })
  default = {
    Project   = "rundog.dev"
    ManagedBy = "opentofu"
  }
}

variable "swa_sku" {
  description = "SKU tier for the static web app"
  type = object({
    tier = string
    size = string
  })
  default = {
    tier = "Free",
    size = "Free"
  }
}