---
title: "System requirements to use the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn about system requirements for the Field Service (Dynamics 365) mobile app.
ms.date: 01/31/2023
ms.topic: conceptual
ms.custom: bap-template
ms.subservice: field-service-mobile
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: JonBaker007
ms.author: jobaker
search.app: 
  - D365CE
  - D365FS
---

# System requirements for the Field Service (Dynamics 365) mobile app

## Field Service requirements

**Field Service version 8.8.22+**

After installing or upgrading to **Field Service v8.8.22+**, the "Field Service" and "Field Service Mobile" apps will appear in the list of apps when you sign in. You can find these apps by going to:

```https://[your-environment-name].crm.dynamics.com/apps```

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service apps.](media/admin-apps.png)

## Mobile device - supported platforms

Field Service (Dynamics 365) mobile app is available for iOS, Android, and Windows platforms. 

To provide the best experience for mobile app users, we recommend using modern devices with high [CPU Benchmark scores on Geekbench](https://browser.geekbench.com/v5/cpu/singlecore).

*The required storage size depends on the [mobile offline profile](mobile-power-app-system-offline.md). It specifies the amount of data that your organization needs to download for when there is no internet access.

### iOS

|   |OS Version |CPU Benchmark Score| Storage|
| --- | --- |--- | --- |
| Minimum |	14 or later |	400+ |	64 GB	| 
| Recommended| 15 or later |	1000+	| 64+ GB	| 

### Android

|   | OS Version  | CPU Benchmark Score   | RAM   | Storage   |
| ------------ | ------------ | ------------ | ------------ | ------------ |
| Minimum  | 9 or later   | 400+   | 4GB   | 64 GB|
| Recommended  | 10 or later   | 900+   | 8 GB   | 64+ GB|

### Windows

|   |OS Version |RAM| Storage|
| --- | --- |--- | --- |
| Minimum |	10 17763.0 or later |	6 GB |	64 GB	| 
| Recommended| 10 19042.1348 or later |	8 GB	| 128 GB	|

> [!NOTE]
> An important consideration before deploying the Field Service (Dynamics 365) mobile app is the hardware specification of the device used, such as memory and processor. Modifying the app with enhancements such as custom configurations and offline javascript may place additional requirements on system memory and processor. Other factors, such as the amount of applications running on the device may also affect app performance.

## Next steps

- [Install and set up the Field Service (Dynamics 365) mobile app](mobile-power-app-get-started.md)
- [Field Service (Dynamics 365) app for Windows 10+ devices](mobile-powerapp-windows.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
