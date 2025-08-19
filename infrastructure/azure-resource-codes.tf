variable "key_vault" {
  description = "key vault code within resource names"
  type        = string
  default     = "kv"
}

variable "resource_group" {
  description = "resource group code within resource names"
  type        = string
  default     = "rg"
}

variable "static_web_app" {
  description = "static web app code within resource names"
  type        = string
  default     = "swa"
}