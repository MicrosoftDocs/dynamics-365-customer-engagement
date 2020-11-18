---
title: "Barcode scanning and global search on the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to get started with the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/30/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Barcode scanning and global search

> [!div class="mx-imgBorder"]
> ![Simulated image showing four mobile devices in different stages of the barcode scan process.](./media/mobile-2020-global-search-use.png)


By default, Dynamics 365 Field Service is configured to search against account, contact, user, and activity. You can customize global search to include additional entities, such as customer asset and product, which helps technicians search, find by keyword, and scan to search by barcode, UPC, or QR code.

For more information, see: [How to Setup Global Search](https://community.dynamics.com/crm/b/xrm/posts/how-to-set-up-global-search-in-microsoft-dynamics-365)

After enabling global search, ensure there is a barcode field on the entity you wish to search via barcode scan. A common example is adding a barcode field to the Customer Asset form. 

See the following video for more details [Use and configure the Dynamics 365 Field Service mobile app](https://youtu.be/tcDt_vJ5csI?t=479). 


Field Service Mobile provides you with the capability of using barcode scanning to read barcodes to fill in value for fields or do a search.

For using the barcode scanning feature,

please follow the below steps:

1. Go to &#39;Field Service mobile&#39; model drive app and select &#39;Open in App Designer&#39;

![](openinappdesigner.png)

1. Go to Edit form and select the form which have the field that you want to utilize for barcode scanning.

![](editform.png)

1. Add a field or select the field that you want to add &#39;Barcode scanning&#39; to

![](addfieldtoform.png)

1. Save and Publish all changes in the form and then &#39;Switch to Classic&#39; view

![](saveandpublish.png) ![](switchtoclassic.png)

1. Select the required field and double click on it

![](findfieldanddoubleclickonit.png)

1. Go to &#39;Controls&#39; tab and click on &#39;Add control&#39;

![](addcontroltofield.png)

1. Select &#39;Barcode scanner&#39; control and add it

![](addbarcodecontrol.png)

1. Enable the control for mobile and tablet, Save and Publish the changes

![](enablefortabandmobile.png) ![](saveandpublish2.png)

1. Now open the App, the form will have the field with the barcode scanner option. Clicking on the Barcode icon will open the camera and read any barcode/QR code.

![](mobilewithfield.png)

The barcode control can be used to read and fill in value to a field or it can be user to setup global search.