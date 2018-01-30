---
title: "Step 4: Test your custom channel tile (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Provides information on how you can make the custom channel tile available in the customer journey designer in Dynamics 365 for Marketing."
ms.custom: ""
ms.date: 12/15/2017
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: db4ef53d-8a48-4b27-899f-8f4c788bc43c
author: "KumarVivek"
ms.author: "kvivek"
robots: noindex,nofollow
manager: "amyla"
---
# Step 4: Test your custom channel tile

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[Pre-release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

To make the custom channel tile available in the customer journey designer:

1. Create a solution. More information: [Create a solution](../../customize/create-solution.md)
2. Add the tile CSS file as a **Style Sheet (CSS)** web resource to the solution you created. Note the generated file name as the name will contain publisher prefix (for example, sample_). This file name needs to be used in the tile XML file. More information: [Create or edit web resources to extend a web application](../../customize/create-edit-web-resources.md)
3. Add the tile XML file as a **Data (XML)** web resource to the solution you created. The file name must end with 'CustomerJourneyDesignerTileConfig.xml’.
4. Save the solution and publish all customizations.
5. Create a customer journey to open the customer journey designer. Go to **Marketing** > **Marketing Execution** > **Customer Journeys**, and then select **New**. For more information about creating a journey, see [Create a simple customer journey](../../marketing/create-simple-customer-journey.md).
    
    The tile should show up in the **Custom Content** section of the tile library in the customer journey designer.

    ![Custom Content tiles](../media/marketing-custom-channel-tile.png)


> [!div class="nextstepaction"]
> [Publish custom channel on AppSource](publish-custom-channel-appsource.md)

### See also

[Web resources for Customer Engagement](../../developer/web-resources.md)



  