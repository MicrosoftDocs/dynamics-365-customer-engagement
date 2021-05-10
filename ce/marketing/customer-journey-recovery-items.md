---
title: "Troubleshoot customer journey customization errors (Dynamics 365 Marketing) | Microsoft Docs"
description: "Use the recovery items tab to troubleshoot customer journey custom workflows in Dynamics 365 Marketing."
ms.date: 04/21/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Troubleshoot customer journey customization errors

The Recovery items tab allows system administrators to track customization errors, improving the customer journey workflow creation process. If there are items in the Recovery items tab, non-system admin users will receive a notification that says, "There are work items to recover. Check the recovery items tab."

> [!div class="mx-imgBorder"]
> ![Customer journey recovery items notification](media/customer-journey-recovery-items-error.png)

The Recovery items tab contains a grid with customization errors and gives administrators options to handle them. For customer journeys, typical errors occur when a CRM workflow is used in a customer journey but is not marked as **On Demand** in the workflow properties.

> [!div class="mx-imgBorder"]
> ![List of customer journey recovery items](media/customer-journey-recovery-items-grid.png)

After selecting rows in the Recovery items tab, you can delete the items (which will delete them from blob storage), or you can fix the issue and "recover" any item, which will replay the previously failed functionality.

### See also

[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Create a simple customer journey](create-simple-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Create an inbound customer journey](create-inbound-customer-journey.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  