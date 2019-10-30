---
title: "Post-requisites steps for migration of configurations | MicrosoftDocs"
description: "Test migration of web client configurations to the unified interface app."
ms.custom: 
  - dyn365-USD
  - dyn365-admin
ms.date: 11/04/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: CAAF7C38-026A-4945-90F1-433766649A9E
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: admin
search.app: 
  - D365CE
  - D365USD
---

# Post-requisites steps for migration of configurations

This topic describes the steps you need to perform after you migrate the configurations from web client to unified interface app.

## Post-requisites

- Re-configure window navigation rules
- Re-configure events
- Update associated views
- Update Unified Service Desk Component type to Chrome (optional)
- Update to Unified Interface theme (optional)

## Test the configurations on the target Unified Interface app.

1. Sign in to the Common Data Service platform.

2. Select the down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select configurations that you migrated from the Web Client.</br>
For example, the selected configuration elements are as follows:

  |Configuration Name|Description|
  |-------|-------|
  |KB Article| CRM Page|
  |KB Search| KM Control|

  ![Select configurations](../media/usd-migration-assistant-selected-configurations.PNG "Selected configurations")</br>
 You must select **Hosted Controls** to verify.</br></br>
 You can see configurations are migrated to Unified Interface specific elements.

  |Configuration Name|Description|
  |-------|-------|
  |KB Article| Unified Interface Page|
  |KB Search| Unified Interface KM Control|
  
  ![Verifying the configuration migration](../media/usd-configuration-migration-verification.PNG "Verifying the configuration migration")