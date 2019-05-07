---
title: "Learn the basics of Field Service Mobile | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 05/06/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Learn the basics of Field Service Mobile

The Field Service Mobile app is what field technicians use to view their schedules, work orders, equipment details, and more as they travel to various customer locations each day. Here are some of the basic details of the application.

## Supported platforms and minimum OS

- Windows 10, desktop + tablet
- iOS 8.0+, phones + tablets
- Android 5.0+, phones + tablets

## Device requirements

**Available Space:** how much space required on the phone depends on how much DB space is needed based on the quantity of records that an organization is having sync for mobile. You can connect to your organization with the app and go to the app's settings on your phone to see how much space the app is utilizing. Note: this amount can and will change based on how much data the app has to sync from the organization. Also note that you should account for how much data will be needed outside of Field Service Mobile (e.g. photos, texts, other apps). 

**RAM:** Minimum 512MB, 1GB is highly recommended, particularly for organizations with lots of records and customizations. That said, how much RAM is required really depends on how many apps a user will be using. For example, organizations that are using mobile device management (MDM) solutions, requiring their users to switch between multiple applications, and so on, should provide mobile devices that have a minimum of 2 GB of RAM.

**Processor:** a common recommendation is to have a clock speed of ~1.4 GHz at a minimum. Again, what other apps will be running should be taken into consideration. 

**Camera:** autofocus is required for both QR and barcode scanning. 

**GPS:** GPS is required if wanting to use any GPS/location functionalities such as navigating, utilizing maps, or location auditing.

## Install

Installing Field Service Mobile involves downloading the "Field Service Mobile" app from the relevant app store and setting up the mobile configuration tool. Instructions for both can be found in the [Field Service installation (web + mobile) doc](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/field-service/install-field-service#download-the-field-service-mobile-app-on-a-phone-or-tablet).

## Upgrade

New versions of the Field Service Mobile app are released in similar cadences to Dynamics 365 for Field Service and can be downloaded and applied to your mobile phone or tablet the same as any other app via your app store. In some cases such as with Windows 10, downloading the app from the Windows Store allows for automatic upgrades as new versions are released.

The mobile configuration tool is also upgraded periodically and new releases can enable you to configure and customize the Field Service Mobile app in new ways.

## Authentication

### OAuth2
The main security token for the application is the application master password. The application uses this master password to encrypt the application database and other sensitive information stored in Field Service Mobile app.

In case of legacy authentication methods which require the app to submit the user’s password to the server (standard user, external user), the server password is used for encrypting the application master password for user’s convenience. With the OAuth2 authentication, the user must provide a dedicated password used for encrypting the application master password. 

Regarding password storage, the app can be configured to either:

- Require the user to enter the password each time the application is launched (or resumed from background), or
- Store the password in the device's secure storage so that the user does not need to type it in repeatedly

### Multi-factor authentication (MFA)
Multi-factor authentication based on the related Office 365 tenant Azure Active Directory can be enabled for Field Service Mobile. This adds a second layer of security with a phone call or text message to user sign-ins and transactions.  

## Security

### Data encryption

Data encryption is based on an application key. The application key is randomly generated and protected by the user password. The key is used to encrypt all local Field Service data. The details of this procedure are explained below.

The application generates the random application key when it creates its local database. Afterwards, it is stored in an encrypted form on the device file system and the application decrypts it when needed. The application key AES256 is used together with the user password (PBKDF2), a random IV and salt for encryption/decryption.

The following explains how the application key is used to secure application data. Remember, there are two data stores: the database and the blob store (attachments).

For encrypting the SQLite database, the application key is passed to the SQLite database driver.

The driver uses the application key and IV to encrypt/decrypt individual database pages using AES128 in CFB mode. Each page (1024 bytes) is encrypted separately. The IV is the page header (contains variable/unpredictable data).

Each file in the blob store (attachment store) contains a header with random IV (16 bytes) and encrypted data. The blob data is encrypted with AES256 in CBC mode using the application key, file header IV. PKCS7 is used for data alignment.

### Synchronization

Synchronization is when the Field Service Mobile app calls the server for new or updated data. As an example, the app will need to synchronize to the server for a field technician to see a new work order booking scheduled by the dispatcher. 

The app can perform a synchronization manually, timed, or on available connection.

- If password stored, sync is automatic​
- If password isn’t stored, requires password entry to sync

The system also tracks a **synchronization log** that tracks when users last synced and on what devices.

### Mobile device management (MDM)

**Lock** - If a device is stolen or there are concerns about the security of offline data, the administrator is able to lock the application remotely on a single device, or a whole group of devices, in just one click and block the user from opening the application.

**Wipe** - In the worst-case scenario you can completely wipe out the data from the application. All is done remotely just by one click and regardless the synchronization. This means that you delete the data remotely from the mobile device and nobody will be longer available to see them.

**Force Full Sync** - By just one click, you can force the application to perform a full synchronization of the data during the next synchronization of the app.

#### Dynamics security

For accessing Dynamics 365 for Field Service entities and fields, the Field Service Mobile app utilizes the Dynamics 365 security role and field security profile framework. In addition, entities and fields can be further restricted at the mobile app level, but a user cannot access any entity or field that could not be accessed in Dynamics 365.


## Key capabilities

**Native application** - Field Service Mobile is a native application on the Windows, iOS, and Android platforms. Because a native app is built for use on a particular device and its OS, it has the ability to better use device-specific hardware and software such as the camera and microphone.

**Offline and Online mode** - Field Service Mobile has full offline capabilities when the mobile app is in "offline mode". This means work order details and other valuable data can be downloaded locally to the field technicians' phones and tablets to use when internet connectivity is not available. When a field technician is working in "online mode" then the data on the mobile app reflects the server data. The mobile app can be put into online mode at all times, only when the device is connected to Wifi, when the field technician manually toggles to online mode, or never. In addition, **sync filters** allow administrators yo decide which entities and records should be downloaded locally for offline mode. As an example, an administrator can say only this week's work orders should be downloaded by filtering based on date.

**GPS** - The phone or tablet's GPS used for location services is extremely valuable for field service scenarios allowing an organization to schedule work orders to the closest available field technician, calculating arrival times to customer locations, and geofencing. 

**Camera**

**Barcode scanning**

**Speech to text**

**Signature**

**Email integration**

**Access documents**

**Push notifications**

## Prerequisites
> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configuration considerations
## Additional Notes

  

OS Specific Requirements: iOS 8+, Android 4.4+, and Windows 10.  



Mobile engineer capabilities - Engineers require a mobile application supported on multiple HW/SW platforms and in different languages which is usable in an on- and off line mode. One engineer may use multiple mobile devices, like a smart phone plus a PC. All devices must synchronize to the dispatch system so that a user can transparently work on any of these devices.

Mobile engineer capabilities - Please describe the concept of your solution for mobile engineers

View Engineer plan, receive, view and accept work order - The mobile application needs to give engineers the ability to understand and manage their work order assignments:
please comment on the extent to which these features are available when there is no connection to the internet:

Report progress - Engineers must be able to update progress of work orders during the delivery process. The mobile application should allow updates independently of whether there is an online connection.
Manage Spare Parts - Engineers must have the capability to manage Spare Parts on the mobile application. Can the tool:

View technical documentation -

Collaborate with dispatch and other resources, support, sales

Collaborate with dispatch and other resources, support, sales - please provide any additional details

Manage customer signatures and forms Q1 - Does your solution support the capture of customer electronic signature on the mobile device? If yes, how is this integrated into a document workflow that can replace paper signatures and how is the security of signatures managed? Please also describe what other forms of electronic signature you support

Manage customer signatures and forms Q2 - Do you support other forms of electronic signature?  If yes, please describe.

Manage customer signatures and forms Q3 - In case there are legal requirements for paper documents, Does your solution provide capabilities to generate and print paper documents using work order data? Can these documents be easily sent to a local printer or emailed to the customer?

Take pictures and attach to work orders - Can your solution take pictures (using the mobile device) and attach them to the work order so that they are synced back to the work order management system?

Use device camera to populate work order fields - Today, the work order closure process is highly manual and requires many steps and entries.Can your solution support a more automated process that utilises data captured through the work order and guides the user to just add the missing pieces?

Perform work order closure - Today, the work order closure process is highly manual and requires many steps and entries.  Can your solution support a more automated process that utilizes data captured through the work order and guides the user to just add the missing pieces? If yes, please describe

Perform work order closure Q2 - The current work order closure process involves the following items.  Please confirm which are supported by your solution.

Capture current engineer location using GPS technology. Please mark check boxes if your solution provides:

Update engineer availability

Case and Work order creation capability - Please describe whether your solution enables the request for creation of additional work orders through the mobile device. Typical situations are

Case and Work order creation capability - Please provide any other related functionality

Alerts for work order progress - The mobile solution must be able to alert the engineer to take action when planned work order milestones are not achieved in time.  Please comment on how you solution handles alerts of this type

Alerts for work order progress Q2 - Can your mobile solution alert the engineer if one of their work orders has been updated by someone else or the system?

Connection status

Manage engineer and user attributes - Finding appropriate field resources, engineers, resident engineers or partners for work orders depends heavily on known field resource capabilities and attributes. These attributes are stored in Salesforce within HPE

Please comment on how your solution would use this information
Access rights and management capabilities Q1 - Explain the resource configuration capabilities and if they support multiple profiles with different data access permissions (Engineers, dispatchers, managers)
Access rights and management capabilities Q2 - Explain the resource configuration capabilities and if they support Internet / Intranet access requirement
Access rights and management capabilities Q3 - Explain the resource configuration capabilities and if they support Auditing capabilities (seeing who changed what when)
"Engineer attributes - In our current solution, engineer attributes are almost all stored and configured in Salesforce and then flow through to our FSM solution via synconisation sessions every 15mins where they are viewable, but not changeable.    
     
Can your solution be configured to similarly integrate and allow changes to be managed in Salesforce?"
Engineer attributes Q2 - Regardless of whether engineer attributes are configured within your tool or via Salesforce, please confirm whether each of the following are attributes your solution uses:
Engineer attributes Q3 - Please comment on which attributes above can be configured separately for working time and stand by time.
"Manage geographical scheduling strategies


Depending on the density of engineers and service orders in a certain geography, different scheduling strategies need to be applied.
 
In some areas, it is preferable to delay part pickup so that we maximize engineer flexibility, whereas it may be preferable to optimize travel time through an early part pickup for areas where we have long travel times and few work orders. On the other hand, we may also have areas like Alaska where automated travel calculation fails because flights or overnight travel are required. Work orders in these areas need to be excluded from automated handling.
 
Please explain whether and how your solution allows the definition of different scheduling strategies for specific geographic areas, and how the scheduling and optimization engine would handle different strategies and exception areas."
Field Capacity Planning - Using the text box in the following question, please describe the field capacity planning strategy that your solution provides, and the detailed capabilities of your solution. Prior to that cna you soluton provide the following capabilities listed?
Field capacity planning capacity - Please use the text box for additional comment
"Managing the mobile devices used by the engineersThis section describes HPE’s needs around the management and deployment of mobile devices to the field engineers.
Background:•HPE has ~1700+ engineers globally•HPE provides all engineers with a laptop for mobile computing •HPE provides all engineers with a mobile device (Smartphone) for voice and data communications•HPE also allows engineers to use the mobility device for personal use outside work hours.•For a subset of users, HPE also provides traditional alphanumeric pagers•Most engineers provide 24x7 standby coverage so the mobility device solution needs to be considered Mission Critical requiring near 100% availability."
Supported devices Q1 - What kinds of devices are supported? Smart phone, tablet, laptop with mobile data connection …?
Supported devices Q2 - What operating systems are supported? What versions?
Supported devices Q3 - Explain in detail how you support the various form factors and operating systems for mobile devices.
Supported devices Q4 - Explain in detail how you support situations where the mobile device is not online (synchronization and conflict resolution)
Supported devices Q5 - Explain how you work with OEMs to get early access to upcoming OS releases for testing?
Supported devices Q6 - Explain how new / updated features are deployed on mobile devices?
"Supported devices Q7 - What are the minimum specifications for the device, in regards to?:
 
 Display size and resolutionMemory / storage requirementsProcessor CameraBattery capacity and life timeGPS, WiFi, Bluetooth, …"
Supported devices Q8 - Do you have a set of recommended makes and models that are specifically tested and validated to work with your solution?
"Mobile Device Evolution - The market of mobile devices and operating systems is evolving very quickly. 
 
What strategy and commitments do you have regarding the support of new devices and new operating systems?
 

How do you ensure compatibility of your application with new devices and enhanced capabilities?"
Managing the mobile device procurement, distribution, inventory, support and renewal - Using the text box after this question, please describe what devices your company supports and what services your company can provide around the procurement, distribution and maintenance of the devices. Before the text box please mark the check boxes if your solution provides the following capabilities
If any of the above were answered with yes, in which countries are such services available?
Managing the mobile device procurement, distribution, inventory, support and renewal - Please describe what devices your company supports and what services your company can provide around the procurement, distribution and maintenance of the devices.
Required mobile communication services - Please describe which communication services have to be in place to make your solution work, and what the expected usage volume of these services will be: Internet Access, What speed and data volume is required?
Required mobile communication services Q2 - Does your solution allow a dispatcher to send a Text/SMS message to an engineer?
Required mobile communication services Q3 - Does your application support or rely on other means of communication, like Twitter, Skype or other 3rd party offerings?  Please explain.
