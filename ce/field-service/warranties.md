---
title: "Warranties in Dynamics 365 Field Service"
description: Learn how to create and use warranties in Dynamics 365 Field Service.
ms.date: 12/07/2022
ms.reviewer: mhart
ms.topic: article
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Warranties in Dynamics 365 Field Service

Warranties are usually a written guarantee of the integrity of a product and of the producer's responsibility for the repair or replacement of defective parts.

In field service context, several scenarios can involve warranties. For example, when an asset is installed on-site or when work gets completed in a functional location.

Dynamics 365 Field Service implements warranties as a separate entity.

## Create a warranty

You can create warranties in the Settings area or directly from related entities. We'll look at creating a warranty from scratch in this procedure.

1. In Field Service, change to the **Settings** area.

1. Go to **Service Delivery** > **Warranties** and select **New**.

1. Provide a **Name**.

1. Choose a service account as **Warranty holder**. The Warranty holder is the service account that receives replacement if a part is defective.

1. Choose a service account as **Warranty provider**. The warranty provider guarantees to replace defective parts.

1. Optionally, enter the **Start Date** and the **End Date** for the warranty.

1. **Save** the record to apply your changes.

## Add related entities

After creating a warranty record, you can add existing assets, locations, and accounts to the warranty to indicate coverage. A warranty can cover multiple assets, functional locations, or service accounts.

1. Open an existing warranty.

1. Select one of more of the following options.

   - In the **Covered assets** section, select **Add Existing Customer Asset**.
   - In the **Covered locations** section, select **Add Existing Functional Location**.
   - In the **Covered accounts** section, select **Add Existing Account**.

1. **Save** the warranty record to apply your changes.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
