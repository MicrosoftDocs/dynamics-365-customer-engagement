---
title: "Create and manage website bindings in Dynamics 365 Portal | MicrosoftDocs"
description: "Learn how to create and manage website bindings in Dynamics 365 Portal."
ms.custom:
  - dyn365-portal
ms.date: 06/20/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 77C8B23E-372B-490A-8AD4-F65585F7B80E
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---

# Create and manage website bindings

In a portal, the default method of selecting a website from within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] is finding a website by matching the name of the website defined in the web.config file of that particular portal. Website bindings provide alternative methods of selecting a website from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] when loading a portal by using the host name and or path of the request to select the appropriate website in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. This eliminates the need to modify separate web.config files for each version of a specific website. This streamlines the deployment of portals across various development, staging, and production environments. Furthermore, this allows a common portal codebase to operate multiple websites.

## Manage website bindings

Website bindings can be created, edited, and deleted within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. 

1. Sign in to [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

2. Go to **Portals** > **Website Bindings**.

3. To create a new website binding, select **New**.

4. To edit an existing website binding, select the website binding name.

5. Enter appropriate values in the fields.

6. Select **Save & Close**.

### Website binding attributes

These are the attributes common to all bindings.

|Name|Description|
|-----|----------|
|Name| A title to identify the website binding when viewing the records in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].|
|Website|The [website](websites.md) that should be selected by the portal.|
|Release Date|A date that determines when the website is allowed to be selected.|
|Expiration Date|A date that determines when the website will stop being selected.|
|||

#### Application Settings

Specify values for these attributes for an application level binding. This binding maps based on IIS website or application.

|Name|Description|
|-----|----------|
|Site Name|The name of the IIS website.|
|Virtual Path|The name of the IIS application under the website.|
|||

For Azure websites and cloud services, the site name and virtual path values are determined by the <Site> and <VirtualApplication> nodes of the **ServiceDefinition.csdef** file.

```
<ServiceDefinition>
  <WebRole>
    <Sites>
      <Site name="Adxstudio Portals">
        <VirtualApplication name="customer-portal"/>
```

### See also
[Create and manage websites](websites.md)