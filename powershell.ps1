# Login to Azure
Connect-AzAccount

# Set your subscription (replace with your subscription id)
Set-AzContext -SubscriptionId "your-subscription-id"

# Create a resource group (replace with your resource group name and location)
New-AzResourceGroup -Name "example-resources" -Location "West Europe"

# Create a storage account (replace with your storage account name)
New-AzStorageAccount -ResourceGroupName "example-resources" -Name "examplestorageaccount" -Location "West Europe" -SkuName Standard_LRS