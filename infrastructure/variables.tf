variable "app_code" {
  description = "Name of the application within the resource name"
  type        = string
  default     = "rrd"
}

variable "azure_region" {
  description = "Azure region"
  type        = map(string)
  default     = {
    location: "UK South",
    code: "uks"
  }
}

variable "app_tags" {
  description = "Tags to apply to all resources"
  type        = map(string)
  default = {
    Project     = "rundog.dev"
    ManagedBy   = "opentofu"
  }
}

variable "swa_sku" {
  description = "SKU tier for the static web app"
  type        = map(string)
  default     = {
    tier: "Free",
    size: "Free"
  }
}