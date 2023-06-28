---
title: Set up postal codes
description: Learn how to set up postal codes and relate them to territories in Dynamics 365 Field Service.
ms.date: 09/22/2022
ms.topic: article
author: ryanchen8
ms.author: chenryan
---
# Create and manage postal codes

Create postal code records to automatically assign accounts to a [service territory](set-up-territories.md). Enter the address on the [account form](accounts.md) and the system automatically populates the service territory if the postal code matches.  
  
Postal codes relate to territories. However, they aren't required for the territories feature to work.

:::image type="content" source="media/work-order-territory-postal-codes.png" alt-text="Screenshot of a territory entity showing postal codes under the related tab.":::
  
You can't assign a postal code to multiple territories.  

## Create a postal code
  
1. In **Field Service**, open the **Settings** area.

1. In the **General** section, select **Postal Codes**.
  
1. Select **New** to create a postal code record.

   - **Name**: Enter the postal code.
   - **Service Territory**: Choose an existing territory or create one.
  
1. Select **Save**.

## Edit a postal code

1. In **Field Service**, open the **Settings** area.

1. In the **General** section, select **Postal Codes**.

1. Select the postal code you want to change and edit the record. You can also select multiple records and select **Edit** if you want to change the territory in bulk.

1. Select **Save**.

## Delete a postal code

1. In **Field Service**, open the **Settings** area.

1. In the **General** section, select **Postal Codes**.

1. Select the postal code you want to remove. You can also select multiple records for deletion.

1. Select **Delete** and confirm the deletion.
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]
