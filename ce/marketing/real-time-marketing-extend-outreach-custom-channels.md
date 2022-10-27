---
title: "Extend your outreach with custom channels (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to extend your outreach with custom channels in Dynamics 365 Marketing."
ms.date: 10/27/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
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

# Preview: Extend your outreach with custom channels

## Custom channel structure

Custom channels can be implemented as part of the Dataverse solution.
A custom channel implementation consists of the following:
1.	Channel definition (solution aware component) 
2.	Message parts (solution aware component)
3.	Channel instance entity and the relevant form
4.	Channel instance account entity (for custom SMS channels only)
5.	Message template (editor) and the relevant form
6.	Custom APIs

### 1. Channel definition
In order to define your channel, you should add a solution component to the solution. To do this, you need to add an XML element with a collection of entities of type **msdyn_channeldefinition** entity attributes to the root element **ImportExportXml** of **customizations.xml** file.

Channel definitions should be added into the **msdyn_channeldefinitions** element under **ImportExportXml** of **customizations.xml** file. Each channel definition should include its own unique id in the form of GUID as XML attribute **msdyn_channeldefinitionid** on channel definition element.
