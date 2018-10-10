# Perform Initial Configurations 

After installing Dynamics 365 for Field Service, there are a few initial configurations that are important whether you are using the application for learning, development, testing, demonstrations, or go-live.

Estimated Duration: 10 minutes

## Prerequisites

1.  Dynamics 365 environment with the Field Service solution and mobile solution (Resco Woodford) installed along with the mobile project imported. Instructions can be found [here](./install-field-service.md).  

2.  Sample data installed (recommended) – installing sample data with the [package deployer](./install-sample-data-8-x.md) will complete many recommended initial configurations  

3.  Verify you can log into Dynamics 365 with a **system administrator** security role

### How do I know if the Field Service solution is installed?

When logged in to Dynamics 365 as an administrator or Field Service role you will see the Field Service module

![Screenshot of Field Service in left navigation bar](media/Perform-Initial-Configurations-image1.png)  

### How do I know if the mobile solution is installed?

When logged in as an administrator Woodford will appear under **Settings > Solutions** and as an icon under Settings

![Screenshot of Woodford solution in solutions views](media/Perform-Initial-Configurations-image2.png)  

![Screenshot of Woodford under Settings](media/Perform-Initial-Configurations-image3.png)  

### How do I know if sample data is imported?

You will see multiple records under **Field Service > Work Orders**

![Screenshot of Work orders in left navigatiion bar](media/Perform-Initial-Configurations-image4.png)  

![Screenshot of Active Work orders view](media/Perform-Initial-Configurations-image5.png)  

## Resource Scheduling

### Scheduling Parameters

The first step is to enable mapping and location services for the application. Maps and locations are very important in Field Service because knowing the location of Work Orders and Resources allows the solution to effectively route the closest field technician (Resource) to the service request (Work Order).

This is accomplished by **geocoding**, where the solution attaches a latitude and longitude to an address.

Navigate to **Resource Scheduling > Administration > Scheduling Parameters**

![Screenshot of Resource Scheduling Administration in Dynamics 365 dropdown menu](media/Perform-Initial-Configurations-image6.png)  

Set **Connect to Maps** to **Yes**.

The API key will be filled out automatically and uses Bing Maps API.

![Screenshot of setting COnnect to Maps to yes](media/Perform-Initial-Configurations-image7.png)  

Save & Close

Later in this article we will test geocoding and location services.

### Enable Resource Scheduling for Entities

Navigate to **Resource Scheduling > Administration > Enable Resource Scheduling for Entities**

![Screenshot of Enabling entities for scheduling](media/Perform-Initial-Configurations-image8.png)  

This is where administrators can decide which entities can be scheduled to Resources. When Field Service is installed, Work Orders are enabled for Resource Scheduling, and when Project Service Automation is installed, Projects are enabled. This is made possible by a solution called Universal Resource Scheduling that adds scheduling capabilities to entities and makes use of the Schedule Board. Any entity including custom entities can be enabled for scheduling and typical examples include Cases, Opportunities, and Orders.

Verify Work Orders are enabled for Resource Scheduling.

## Field Service Settings

Navigate to **Field Service > Administration > Field Service Settings**

![Screenshot of Field Service Administration from Dynamics 365 dropdown menu](media/Perform-Initial-Configurations-image9.png)  

![Screenshot of Field Service Settings](media/Perform-Initial-Configurations-image10.png)  

In the **Other** section, decide if you would like the application to auto geocode addresses. Recommended setting is **Yes.**

![Screenshot of setting Auto Geocode Addresses to Yes](media/Perform-Initial-Configurations-image11.png)  

This means after entering an address on entities such as Accounts, Contacts, Users, and Work Orders, the system will automatically attempt to locate the address and populate latitude and longitude values. Not auto geocoding addresses would require the user to select a Geocode button.

Next, navigate to the **Work Order / Booking** section and enter a Work Order Prefix and Work Order Starting Number.

An example is **WO** and **100**. This is not required but recommended.

![Screenshot of Work Order Prefix and starting number](media/Perform-Initial-Configurations-image12.png)  

## Test Geocoding

Finally, let’s test Geocoding as it is a very important feature to use and understand.

Navigate to **Field Service > Work Orders** and select +New

Begin typing an address

![Screenshot of Work Order address form](media/Perform-Initial-Configurations-image13.png)  

The system will find the address

![Screenshot of address](media/Perform-Initial-Configurations-image14.png)  

And after selecting, it will populate the rest of the address **including the latitude and longitude**.

![Screenshot of address with latitude and longitude populated on work order form](media/Perform-Initial-Configurations-image15.png)  

If you do not want the system to auto geocode addresses, this can be accomplished by selecting the Geocode button in the top ribbon.

![Screenshot of Geocode button](media/Perform-Initial-Configurations-image16.png)  

>[!Note]
> **Pro Tip \#1:** When using the Field Service application, it is uncommon to enter addresses on a work order. The standard process is to geocode accounts, and when a service account is entered on a work order as the service location, the geocoded address is pulled from the account and added to the work order.

>[!Note]
> **Pro Tip \#2:** It is possible to geocode multiple records at one time by selecting the records from a view. In the picture below, we are mass geocoding accounts.

![Screenshot of mass Geocoding multiple account records](media/Perform-Initial-Configurations-image17.png)  

## Mobile

There are a few configurations that should be considered in relation to the mobile application that field technicians will use to carry out work orders.

The following section requires you have the mobile solution (Resco Woodford) installed along with the mobile project imported. Instructions can be found [here](./install-field-service.md).  

In a **non-private internet explorer browser**, log into your Dynamics 365 organization as a system administrator and navigate to **Settings > Woodford > MobileCRM Woodford**

![Screenshot of opening Internet Explorer from Edge](media/Perform-Initial-Configurations-image18.png)  

>[!Note]
>**Pro Tip:** Alternatively, instead of Internet Explorer, you can download the Resco Woodford standalone application. Just once, in a **non-private internet explorer browser,** navigate to <https://www.resco.net/mobilecrm/woodford.html> and download the standalone application and launch it.

Whether you access from the standalone application or Internet Explorer, you will be taken to the Woodford interface

![Screenshot of Woodford interface](media/Perform-Initial-Configurations-image19.png)  

Navigate to **Plugins > Delete**

And select Work Orders and related Work Order entities such as Work Order Products, Services, and Service Tasks.

This helps ensure that when Work Orders or related records are deleted on the server they are removed from the mobile app as well. For more details see the Woodford Guide: <https://www.resco.net/downloads/Woodford_Guide.pdf>

![Screenshot of Delete plugins section of Woodford](media/Perform-Initial-Configurations-image20.png)  

**Save**.

Next, navigate to Mobile Projects and double click on your mobile project template

Select **Configuration** in the left pane.

![Screenshot of Woodford mobile Configurations](media/Perform-Initial-Configurations-image21.png)  

This section details many configurations regarding the Field Service Mobile (2017) app user interface and how data passes back and forth between the mobile application and the server.

Here are a few important configurations to consider when initially setting up the mobile app from an administrator’s perspective.

**Auto Sync:** dictates when the mobile app sends data to the server. Setting to **OnStart** is recommended for learning and demonstration purposes.

**Auto Sync Delay:** is a timer that dictates when the mobile app will automatically try to send and receive data from the server.

**Save Password:** dictates whether the mobile app will remember a user’s password. Setting to **True** is recommended for learning and demonstration purposes.
