---
title: "Personas and privileges | MicrosoftDocs"
description: "Get information about the privileges and recommended access levels for administrator, supervisor, and agent personas in Customer Service and Omnichannel for Customer Service."
ms.date: 08/31/2021
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---

# Personas and privileges

## Introduction

This topic lists the table privileges and recommended access levels for the administrator, supervisor, and agent personas in Customer Service and Omnichannel for Customer Service.

To know more about the various access levels, see [Security roles](/power-platform/admin/security-roles-privileges#security-roles).

For more information about how personas are mapped to roles, see [Manage personas](role-persona-mapping.md#manage-personas).

> [!Note]
> If custom plug-ins and workflows are used in the system, then you must ensure that the required privileges are granted to the personas, otherwise your plug-ins won't work.


## Persona: Administrator

The following table lists the privileges and recommended access levels for the admin persona.

|	Table name                            |	Table unique name	                  |	Privilege name                |Recommended access level	|
|	   -----                              |------  |	------                          |	  ---              	|
|	Activity	                          |	Activity	                          |	Append, Append To, Delete, Update	            |	Local	|
|		                                  |		                                  |	Assign	                                        |	Deep	|
|		                                  |		                                  |	Create	                                          |	Basic	|
|		                                  |		                                  |	Read, Share	                     |	Global	|
|	AdminAppState	                      |	msdyn_adminappstate	                  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Agent Status history	              |	msdyn_agentstatushistory	          |	Create, Delete, Read, Update                 |	Global	|
|	AI Configuration	                  |	msdyn_aiconfiguration	              |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	AI Model	                          |	msdyn_aimodel	                      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	AI Template	                          |	msdyn_aitemplate	                  |	Read	                     |	Global	|
|	App Module	                          |	AppModule	                          |	Read, Update	                |	Global	|
|	App Profile	                          |	msdyn_appconfiguration	              |	Append, Append To, Create, Delete, Read, Update	 |	Global	|
|	App Configuration	                  |	AppConfig	                          |	Read	                               |	Global	|
| App Parameter Definition<br>(Deprecated)</br>| msdyn_consoleappparameterdefinition | Append, Append To, Create, Delete, Read, Update | Global	|
|	Application Extension	              |	msdyn_applicationextension	          |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Application Tab Template	          |	msdyn_applicationtabtemplate	      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Application Tab Template <br>(Deprecated)</br> |	msdyn_consoleapplicationtemplate | Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Application Type (Deprecated)	      |	msdyn_consoleapplicationtype	      |	Append, Append To, Create, Delete, Read, Update	 |	Global	|
|	Assignment Configuration	          |	msdyn_assignmentconfiguration	      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Assignment Configuration Step	      |	msdyn_assignmentconfigurationstep     |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Audio File	                          |	msdyn_soundfile	                |	Append, Append To, Create, Delete, Read, Update	      |	Global	|
|	Bookable Resource	                  |	BookableResource	            |	Append, Append To, Create, Delete, Read, Update	      |	Global	|
| Bookable Resource Capacity<br>Profile</br>| msdyn_bookableresourcecapacityprofile | Append, Append To, Assign, Create, Delete, Read, Share, Update| Global |
|	Bookable Resource Characteristic	  |	BookableResourceCharacteristic	      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Capacity Profile	            |	msdyn_capacityprofile	        |	Append, Append To, Assign, Create, Delete, Read, Share, Update| Global |
|	channel	                              |	msdyn_channel	                      |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Channel Provider	                  |	msdyn_channelprovider	              |	Create, Delete, Read, Update	                 |	Global	|
|	Channel Configuration	              |	msdyn_occhannelconfiguration	      |	Read, Update	                                 |	Global	|
|	Channel Integration Framework <br>v1.0 Provider</br> |	msdyn_ciprovider      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Channel State Configuration	          |	msdyn_occhannelstateconfiguration	  |	Read	                                         |	Global	|
|	Characteristic	                      |	Characteristic	                      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Characteristic mapping	              |	msdyn_ocsitdskill	                  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Charts	                              |	SavedQueryVisualizations	          |	Read	                                          |	Global	|
|	Columns	                              |	Attribute	                          |	Update	                                          |	Global	|
|	Context item value	                  |	msdyn_ocliveworkitemcontextitem	      |	Append, Create, Delete, Read, Update	         |	Global	|
|	Context variable	                  |	msdyn_ocliveworkstreamcontextvariable |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Conversation Capacity<br>profile<br> |	msdyn_ocliveworkitemcapacityprofile | Append, Append To, Assign, Create, Delete, Read, Share, Update | Global|
|	Conversation Characteristic	          |	msdyn_ocliveworkitemcharacteristic	  |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Conversation Sentiment	              |	msdyn_ocliveworkitemsentiment	  |	Create, Delete, Read, Update	                      |	Global	|
|	Custom messaging account	          |	msdyn_ocbotchannelregistration | Append, Append To, Create, Delete, Read, Update  	      |	Global	|
|	Customization	                      |	Customization	              |	Publish, Read, Update	                                  |	Global	|
||||

|	Table name                	|	Table unique name	                                |	Privilege name	          | Recommended access level |
|-----------                    |--------------------                                       |-----------------        | -------- |
|	Decision contract	                  |	msdyn_decisioncontract	|Append, Append To, Assign, Create, Delete, Read, Share, Update |	Global	|
|	Decision rule set	                  |	msdyn_decisionruleset	| Append, Append To, Assign, Create, Delete, Read, Share, Update |	Global	|
|	Deprecated Workstream<br>Entity Configuration</br>	 |	msdyn_entityconfig	  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Entity	                              |	msdyn_entityroutingconfiguration	  |	Append, Append To, Create, Delete, Read, Update  |	Global	|
|	Entity Routing Context	              |	msdyn_cdsentityengagementctx	      |	Create, Delete, Read, Update	         |	Global	|
|	Forms	                              |	SystemForm	                          |	Read	                                  |	Global	|
|	Geo Location Provider	              |	msdyn_oc_geolocationprovider	      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	KPI Event Definition	              |	msdyn_kpieventdefinition	          |	Read	                                  |	Global	|
|	Language	                          |	msdyn_oclanguage	                  |	Read, Append To	                          |	Global	|
|	Live work item event	              |	msdyn_liveworkitemevent	              |	Create, Delete, Read, Update		      |	Global	|
|	Live Work Item Participant<br>(Deprecated)</br> |	msdyn_ocliveworkitemparticipant	  |	Create, Delete, Read, Update	  |	Global	|
|	Localization	                      |	msdyn_oclocalizationdata	          |	Append, Append To, Create, Delete, Read, Update	 |	Global	|
|	Masking Rule	                      |	msdyn_maskingrule	                  |	Create, Delete, Read, Update	            |	Global	|
|	Master Entity Routing<br>Configuration</br> |	msdyn_masterentityroutingconfiguration	  |	Create	                  | Local	|
|		                                  |		                                  |	Append, Append To, Assign, Read, Share, Update	  |	Global	|
|		                                  |		                                  |	Delete	                                  |	Deep	|
|	Message	                              |	msdyn_ocsystemmessage	      |	Append, Append To, Create, Delete, Read, Update	       |	Global	|
|	Model training details	              |	msdyn_ocsimltraining	      |	Append, Append To, Create, Delete, Read, Update	          |	Global	|
|	Notification Field	           |	msdyn_notificationfield	          |	Append, Append To, Create, Delete, Read, Update	          |	Global	|
|	Notification Template	          |	msdyn_notificationtemplate	          |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Notification Field (Deprecated)	  |	msdyn_consoleapplicationnotificationfield	 | Append, Append To, Create, Delete, Read, Update  | Global	|
|	Notification Template <br>(Deprecated)</br>	  |	msdyn_consoleapplicationnotificationtemplate | Append, Append To, Create, Delete, Read, Update |Global	|
|	Omnichannel Queue (deprecated)	      |	msdyn_omnichannelqueue	     | Append, Append To, Assign, Create, Delete, Read, Update	  |	Global	|
|	Omnichannel Configuration	          |	msdyn_omnichannelconfiguration	      |	Append, Append To, Read, Update	          |	Global	|
|	Omnichannel Personalization	          |	msdyn_omnichannelpersonalization	  |	Create, Delete, Read, Update	          |	Global	|
|	Ongoing conversation<br>(Deprecated)</br>	  |	msdyn_liveconversation	              |	Append, Append To, Update	              |	Local	|
|		                                  |		                                  |	Assign	                                  |	Deep	|
|		                                  |		                                  |	Create	                                  |	Basic	|
|		                                  |		                                  |	Read, Share	                              |	Global	|
|	Operating Hour	                      |	msdyn_operatinghour	           |	Append, Append To, Create, Delete, Read, Update	    |	Global	|
|	Pane tool configuration	              |	msdyn_panetoolconfiguration           |	Read	                                  |	Global	|
|	Parameter (Deprecated)	      | msdyn_consoleapplicationtemplateparameter | Append, Append To, Create, Delete, Read, Update   | Global	|
|	Persona Security Role Mapping	      |	msdyn_personasecurityrolemapping	  |	Append, Append To, Create, Delete, Read, Update	 |	Global	|
|	Personal quick reply	              |	msdyn_personalmessage	              |	Append, Append To, Create, Delete, Read, Update	 |	Basic	|
|	Personal sound setting	              |	msdyn_personalsoundsetting	          |	Append, Append To, Create, Delete, Read, Update	 |	Basic	|
|	PluginAssembly	                      |	PluginAssembly	                      |	Read	                                  |	Global	|
|	PluginType	                          |	PluginType	                          |	Read	                                  | Global	|
|	Power BI Configuration	              |	msdyn_analytics	                      |	Create, Delete, Read, Update	          |	Global	|
|	Presence	                          |	msdyn_presence	                 |	Append, Append To, Create, Delete, Read, Update	    |	Global	|
|	Productivity pane configuration	      |	msdyn_paneconfiguration	              |	Read	                                  |	Global	|
|	Provisioning State	                  |	msdyn_ocprovisioningstate	     |	Append, Append To, Create, Delete, Read, Update	     |	Global	|
|	Publisher	                          |	Publisher	                          |	Read	                                  |	Global	|
|	Publisher Address	                  |	PublisherAddress	                  |	Read	                                  |	Global	|
||||

|	Table name                	|	Table unique name	                                |	Privilege name	          | Recommended access level |
|-----------                    |--------------------                                       |-----------------        | -------- |
|	Query	                              |	Query	                              |	Read, Update	                          |	Global	|
|	Queue	                              |	Queue	                      |	Append, Append To, Assign, Create, Delete, Read, Update   |	Global	|
|	Quick reply	                          |	msdyn_cannedmessage	                  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Rating Model	                      |	RatingModel	                          |	Append, Append To, Create, Delete, Read, Update	 |	Global	|
|	Rating Value	                      |	RatingValue	                          |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Recording	                          |	msdyn_ocrecording	                  |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Relationship	                      |	Relationship	                      |	Update	                                  |	Global	|
|	Role	                              |	Role	                              |	Append To, Assign, Read	                   |	Global	|
|	Routing configuration	              |	msdyn_routingconfiguration	          |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Routing configuration step	          |	msdyn_routingconfigurationstep	      |	Append, Append To, Create, Delete, Read, Update |	Global	|
|	Rule Item	                          |	msdyn_ocruleitem	                  |	Append, Append To, Create, Delete, Read, Update |	Global	|
|	Rulesetentitymapping	      |	msdyn_rulesetdependencymapping     |	Append, Append To, Assign, Create, Delete, Read, Update   |	Global	|
|	Scenario	                          |	msdyn_scenario	                      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	SdkMessage	                          |	SdkMessage	                          |	Read	                                  |	Global	|
|	SdkMessageProcessingStep	          |	SdkMessageProcessingStep	          |	Read	                                  |	Global	|
|	SdkMessageProcessingStepImage	      |	SdkMessageProcessingStepImage         |	Read	                                  |	Global	|
|	Search Configuration	              |	msdyn_searchconfiguration	          |	Create, Delete, Read, Update	          |	Global	|
|	Self service	                      |	msdyn_visitorjourney	              |	Read	                                  |	Global	|
|	Sentiment Analysis	                  |	msdyn_sentimentanalysis	              |	Read, Update	                          |	Global	|
|	Service Endpoint	                  |	ServiceEndpoint	                      |	Read	                                  |	Global	|
|	Session event	                      |	msdyn_sessionevent	                  |	Create, Delete, Read, Update	          |	Global	|
|	Session Template	                  |	msdyn_sessiontemplate	              |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Session Characteristic	              |	msdyn_ocsessioncharacteristic         |	Append, Append To, Create, Delete, Read, Update  |	Global	|
|	Session participant	                  |	msdyn_sessionparticipant	          |	Create, Delete, Read, Update 	  |	Global	|
|	Session Templates<br>(Deprecated)</br>	 |	msdyn_consoleapplicationsessiontemplate	  |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	SharePoint Data	                      |	SharePointData	                      |	Create, Read, Update 	                          |	Global	|
|	SharePointDocument	                  |	SharePointDocument	                  |	Read	                                  |	Global	|
|	Skill finder model	                  |	msdyn_ocskillidentmlmodel	          |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Solution	                          |	Solution	                          |	Read, Update	                                  |	Global	|
|	Sound notification setting	          |	msdyn_soundnotificationsetting	      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	System User	                          |	User	                              |	Append, Append To, Create, Read, Update	  |	Global	|
|	Table	                              |	Entity	                              |	Update	                                  |	Global	|
|	Tag	                                  |	msdyn_octag	                          |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Template Parameter	                  |	msdyn_templateparameter	              |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Template Tag (Deprecated)	          |	msdyn_templatetags	                  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Training data import<br>configuration</br> |	msdyn_ocsitdimportconfig	  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Training record	                      |	msdyn_ocsitrainingdata	              |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	Transcript	                          |	msdyn_transcript	                  |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|	Unified routing diagnostic	          |	msdyn_unifiedroutingdiagnostic	      |	Delete, Read, Update	                          |	Global	|
|	Unified routing run	                  |	msdyn_unifiedroutingrun	              |	Delete, Read	                                  |	Global	|
|	UR notification template	          |	msdyn_urnotificationtemplate	      |	Append, Append To, Create, Delete, Read, Update   |	Global	|
|	UR Notification Template <br>Mapping</br>|	msdyn_urnotificationtemplatemapping	| Append, Append To, Create, Delete, Read, Update | Global  |
|	User Setting	                      |	msdyusd_usersettings                  |	Append, Append To, Read, Update	                  |	Global	|
|	User settings	                      |	msdyn_usersettin                      |	Append, Append To, Create, Delete, Read, Update	  |	Global	|
|   Work stream capacity<br>profile</br> | msdyn_liveworkstreamcapacityprofile | Append, Append To, Assign, Create, Delete, Read, Share, Update | Global |
|	Workstream	                          | msdyn_liveworkstream |	Append, Append To, Assign, Create, Delete, Read, Share, Update  | Global	|
| | | | 


## Persona: Supervisor

The following table lists the privileges and recommended access levels for the supervisor persona.

|	Table name (A-O)                	|	Table unique name	                                |	Privilege name	          | Recommended access level |
|-----------                    |--------------------                                       |-----------------        | -------- |
|	Activity	                    |	Activity	                                        |	Append, Append To, Delete, Update   |	Local	|
|	                            	|	        	                                        |	Assign	                           |	Deep	|
|	                            	|	                                                	|	Create                            |	Basic	|
|	                            	|	                                        	        |	Read, Share	                    |	Global	|
|	Agent Status history	        |	msdyn_agentstatushistory	                        |	Read                             |	Global	|
|	App Module	                    |	AppModule	                                        |	Read	                           |	Global	|
|	App Profile	                    |	msdyn_appconfiguration	                            | 	Read	                            |	Global	|
|	App Parameter Definition<br> (Deprecated)</br>	|	msdyn_consoleappparameterdefinition	|	Read	                           |	Global	|
|	Application Extension	        |	msdyn_applicationextension	                        |	Read                               |	Global	|
|	Application Tab Template	    |	msdyn_applicationtabtemplate          	            |	Read	                           |	Global	|
|	Application Tab Template <br>(Deprecated)</br>	|	msdyn_consoleapplicationtemplate	|	Read                             |	Global	|
|	Application Type (Deprecated)	|	msdyn_consoleapplicationtype	                    |	Read	                |	Global	|
|	Audio File                    	|	msdyn_soundfile	                         |	Append, Append To, Create, Delete, Read, Update	|	Global	|
|	Bookable Resource            	|	BookableResource	                                |	Read	                              |	Global	|
|	Bookable Resource <br>Characteristic</br>	|	BookableResourceCharacteristic	        |	Read	                              |	Global	|
|	channel	                        |	msdyn_channel	                                    |	Read                                  |	Global	|
|	Channel Provider            	|	msdyn_channelprovider	                            |	Read                                 |	Global	|
|	Channel Integration Framework <br>v1.0 Provider</br>	    |	msdyn_ciprovider	    |	Read                                  |	Global	|
|	Characteristic	                |	Characteristic                                  |  Read	                                  |	Global	|
|	Context item value             	|	msdyn_ocliveworkitemcontextitem            |	Read	                                |	Global	|
|	                              	|	                                            	|	Append, Create, Update                    |	Basic	|
|	Context variable	            |	msdyn_ocliveworkstreamcontextvariable	     |	Read	                                      |	Global	|
|	Conversation Characteristic	    |	msdyn_ocliveworkitemcharacteristic     	      |	Read	                                      |	Global	|
|	Conversation Sentiment        	|	msdyn_ocliveworkitemsentiment                 |	Read	                                      |	Global	|
|	Custom messaging account       	|	msdyn_ocbotchannelregistration               |	Read	                                      |	Global	|
|	Deprecated Workstream <br>Entity Configuration</br>	|	msdyn_entityconfig     	|	Read	                                      |	Global	|
|	Entity	                        |	msdyn_entityroutingconfiguration    	      |	Read	                                      |	Global	|
|	Entity Routing Context	        |	msdyn_cdsentityengagementctx                	|	Read	                                 |	Global	|
|	Geo Location Provider        	|	msdyn_oc_geolocationprovider	              |	Read	                                      |	Global	|
|	Language	                    |	msdyn_oclanguage	                         |	Read	                                      |	Global	|
|	Live work item event          	|	msdyn_liveworkitemevent	                     |	Read	                                      |	Global	|
|	Live Work Item Participant <br>(Deprecated)</br>	|	msdyn_ocliveworkitemparticipant	|	Read	                         |	Global	|
|	Localization	                |	msdyn_oclocalizationdata	                 |	Create, Delete, Read, Update	              |	Global	|
|	Masking Rule	                |	msdyn_maskingrule	                                |	Read	                           |	Global	|
|	Master Entity Routing <br>Configuration</br>	|	msdyn_masterentityroutingconfiguration	|	Read                      	  |	Global	|
|	Message                        	|	msdyn_ocsystemmessage	                            |	Create, Delete, Read, Update    |	Global	|
|	Notification Field            	|	msdyn_notificationfield	                            |	Read	                           |	Global	|
|	Notification Template	        |	msdyn_notificationtemplate	                        |	Read	                            |	Global	|
|	Notification Field (Deprecated)	|	msdyn_consoleapplicationnotificationfield        	|	Read                                  |	Global	|
|	Notification Template <br>(Deprecated)</br>	|	msdyn_consoleapplicationnotificationtemplate	|	Read                      	  |	Global	|
|	Omnichannel Queue (deprecated)	|	msdyn_omnichannelqueue	                            |	Append, Append To, Read	              |	Global	|
|	Omnichannel Configuration	|	msdyn_omnichannelconfiguration	                        |	Read	                              |	Global	|
|	Omnichannel Personalization	|	msdyn_omnichannelpersonalization	                    |	Create, Delete, Read, Update	      |	Basic	|
|	Ongoing conversation <br>(Deprecated)</br>	|	msdyn_liveconversation	                |	Create	                              |	Basic	|
|		                                        |	                    	                |	Read, Share	                          |	Global	|
|	                                        	|	                    	                |	Append, Append To, Update          	  |	Local	|
|		                                        |	                    	                |	Assign	                              |	Deep	|
|	Operating Hour	                            |	msdyn_operatinghour    	                |	Read	|	Global	|
||||


|	Table name                            |	Table unique name	                  |	Privilege name                |	Recommended access level	|
|	   -----                              |------	                              |	------                          |	  ---              	|
|	Parameter (Deprecated)            	|	msdyn_consoleapplicationtemplateparameter	    |	Read	|	Global	|
|	Persona Security Role Mapping    	|	msdyn_personasecurityrolemapping	            |	Read	|	Global	|
|	Personal quick reply            	|	msdyn_personalmessage	              |	Append, Append To, Create, Delete, Read, Update	|	Basic	|
|	Personal sound setting            	|	msdyn_Personalsoundsetting	          |	Append, Append To, Create, Delete, Read, Update |	Basic	|
|	PluginAssembly                    	|	PluginAssembly	                                |	Read	                            |	Global	|
|	PluginType                        	|	PluginType	                                    |	Read	                            |	Global	|
|	Power BI Configuration             	|	msdyn_analytics	                                |	Read	                            |	Global	|
|	Presence	                        |	msdyn_presence                                	|	Append, Append To, Read            	|	Global	|
|	Provisioning State                 	|	msdyn_ocprovisioningstate	                    |	Read	                            |	Global	|
|	Queue	                            |	Queue	                                        |	Append, Append To, Read	            |	Global	|
|	Quick reply	                        |	msdyn_cannedmessage	                            |	Create, Delete, Read, Update    	|	Global	|
|	Rating Model	                    |	RatingModel	                                    |	Read                            	|	Global	|
|	Rating Value	                    |	RatingValue                                    	|	Read	|	Global	|
|	Recording	                        |	msdyn_ocrecording                              	|	Read	|	Global	|
|	Role	                            |	Role	                                        |	Read	|	Global	|
|	Rule Item                        	|	msdyn_ocruleitem                            	|	Read	|	Global	|
|	Scenario                        	|	msdyn_scenario                                	|	Read	|	Global	|
|	SdkMessage                        	|	SdkMessage                                    	|	Read	|	Global	|
|	SdkMessageProcessingStep        	|	SdkMessageProcessingStep                    	|	Read	|	Global	|
|	SdkMessageProcessingStepImage	    |	SdkMessageProcessingStepImage	                |	Read	|	Global	|
|	Search Configuration	            |	msdyn_searchconfiguration	                    |	Read	|	Global	|
|	Self service                    	|	msdyn_visitorjourney	                        |	Read	|	Global	|
|	Sentiment Analysis                 	|	msdyn_sentimentanalysis                        	|	Read	|	Global	|
|	Service Endpoint	                |	ServiceEndpoint	                                |	Read	|	Global	|
|	Session event	                    |	msdyn_sessionevent                            	|	Read	|	Global	|
|	Session Template	                |	msdyn_sessiontemplate	                        |	Read	|	Global	|
|	Session Characteristic            	|	msdyn_ocsessioncharacteristic	                |	Read	|	Global	|
|	Session participant	                |	msdyn_sessionparticipant	                    |	Read	|	Global	|
|	Session Templates (Deprecated)    	|	msdyn_consoleapplicationsessiontemplate        	|	Read	|	Global	|
|	SharePoint Data	                    |	SharePointData                                	|	Create, Read, Update            	|	Global	|
|	SharePointDocument                 	|	SharePointDocument	                            |	Read	                            |	Global	|
|	Solution	                        |	Solution                                    	|	Read	                            |	Global	|
|	Sound notification setting        	|	msdyn_soundnotificationsetting     |	Append, Append To, Create, Delete, Read, Update	| Global|
|	System User	                        |	User	                           |	Append, Append To, Create, Read, Update	|	Local	|
|	Tag	                                |	msdyn_octag	                       |	Append, Append To, Create, Delete, Read, Update	|	Global	|
|	Template Parameter                 	|	msdyn_templateparameter	                        |	Read	                            |	Global	|
|	Template Tag (Deprecated)        	|	msdyn_templatetags                            	|	Read	                            |	Global	|
|	Transcript                        	|	msdyn_transcript                            	|	Read	                            |	Global	|
|	UR notification template          	|	msdyn_urnotificationtemplate                	|	Read	                            |	Global	|
|	UR Notification Template Mapping	|	msdyn_urnotificationtemplatemapping	            |	Read	                            |	Global	|
|	User Setting                    	|	msdyusd_usersettings	                        |	Append, Append To, Read, Update		|	Global	|
|	User settings	                    |	msdyn_usersetting	           |	Append, Append To, Create, Delete, Read, Update	|	Global	|
|	Workstream                        	|	msdyn_liveworkstream	                        |	Read	                            |	Global	|
||||

## Persona: Agent

The following table lists the privileges and recommended access levels for the agent persona.

|	Table name                    	|	Table unique name	            |	Privilege name	                          | Recommended access level |
|---------------                    |--------------------               |-----------------                            | --------          |
|	Activity	                    |	Activity	                    |	Append, Append To, Delete, Update	                |	Local	|
|	                            	|	                            	|	Assign                                            	|	Deep	|
|	                        	    |	                                |	Create                                             	|	Basic	|
|	                            	|	                            	|	Read, Share                                        	|	Global	|
|	Agent Status history    	    |	msdyn_agentstatushistory        |	Read	                                            |	Global	|
|	App Module                    	|	AppModule	                    |	Read                                            	|	Global	|
|	App Profile                    	|	msdyn_appconfiguration        	|	Read	                                            |	Global	|
|	App Parameter Definition <br>(Deprecated)</br>	|	msdyn_consoleappparameterdefinition	|	Read	                        |	Global	|
|	Application Extension	        |	msdyn_applicationextension    	|	Read                                            	|   Global	|
|	Application Tab Template	    |	msdyn_applicationtabtemplate	|	Read                                            	|	Global	|
|	Application Tab Template <br>(Deprecated)</br>	|	msdyn_consoleapplicationtemplate	|	Read                        	|	Global	|
|	Application Type <br>(Deprecated)</br>	|	msdyn_consoleapplicationtype	|	Read	                                    |	Global	|
|	Assignment Configuration    	|	msdyn_assignmentconfiguration	|	Read                                            	|	Global	|
|	Assignment Configuration<br> Step</br>	|	msdyn_assignmentconfigurationstep	|	Read	                                |	Global	|
|	Audio File                    	|	msdyn_soundfile	                |	Append, Append To, Read	                            |	Global	|
|	Bookable Resource          	    |	BookableResource	|	Read		                                                    |   Global	|
|	Bookable Resource Capacity<br> Profile</br>	|	msdyn_bookableresourcecapacityprofile	|	Read	                        |	Local	|
|	Bookable Resource <br>Characteristic</br>	|	BookableResourceCharacteristic	|	Read	                                |	Global	|
|	Capacity Profile            	|	msdyn_capacityprofile	|	Read	                                                    |	Basic	|
|	channel	                        |	msdyn_channel	    |	Read	                                                        |	Global	|
|	Channel Provider            	|	msdyn_channelprovider	|	Read	                                                    |	Global	|
|	Channel Integration Framework<br> v1.0 Provider</br>	|	msdyn_ciprovider	|	Read	                                |	Global	|
|	Characteristic                	|	Characteristic	|	Read	                                                            |	Global	|
|	Characteristic mapping	        |	msdyn_ocsitdskill	|	Read	                                                        |	Global	|
|	Context item value	            |	msdyn_ocliveworkitemcontextitem	|	Read	                                            |	Global	|
|	                            	|	                            	|	Append, Create, Update	                            |	Basic	|
|	Context variable	            |	msdyn_ocliveworkstreamcontextvariable	|	Read	                                    |	Global	|
|	Conversation Capacity profile	|	msdyn_ocliveworkitemcapacityprofile    	|	Read	                                    |	Local	|
|	Conversation Characteristic    	|	msdyn_ocliveworkitemcharacteristic    	|	Read                                       	|	Global	|
|	Conversation Sentiment        	|	msdyn_ocliveworkitemsentiment	        |	Read	                                    |	Global	|
|	Custom messaging account    	|	msdyn_ocbotchannelregistration	        |	Read	                                    |	Global	|
|	Decision contract	            |	msdyn_decisioncontract	                |	Append, Append To, Read	                    |	Global	|
|	                            	|		                                    |	Assign, Share	                            |	Basic	|
|	Decision rule set	            |	msdyn_decisionruleset	                |	Append, Append To, Read	                    |	Global	|
|                            		|		                                    |	Assign, Share	                            |	Basic	|
|	Deprecated Workstream <<br>Entity Configuration</br>	|	msdyn_entityconfig	|	Read	                                |	Global	|
|	Entity	                        |	msdyn_entityroutingconfiguration	        |	Read	                                |	Global	|
|	Entity Routing Context	        |	msdyn_cdsentityengagementctx	            |	Read	                                |	Global	|
||||

|	Table name                            |	Table unique name	                  |	Privilege name                |	Recommended access level	|
|	   -----                              |------	                              |	------                          |	  ---              	|
|	KPI Event Definition	        |	msdyn_kpieventdefinition	                |	Read	                                |	Global	|
|	Language	                    |	msdyn_oclanguage	                        |	Read	                                |	Global	|
|	Live work item event	        |	msdyn_liveworkitemevent                    	|	Read	                                |	Global	|
|	Live Work Item Participant <br>(Deprecated)</br>	|	msdyn_ocliveworkitemparticipant	|	Read	                        |	Global	|
|	Localization	                |	msdyn_oclocalizationdata	                        |	Read	                        |	Global	|
|	Masking Rule	                |	msdyn_maskingrule	                                |	Read	                        |	Global	|
|	Master Entity Routing <br>Configuration</br>	|	msdyn_masterentityroutingconfiguration	|	Append, Append To, Read      |	Global	|
|		                                            |		                                    |	Assign, Share	            |	Basic	|
|	Message                        	|	msdyn_ocsystemmessage	                                |	Read	                    |	Global	|
|	Model training details         	|	msdyn_ocsimltraining                                	|	Read	                    |	Global	|
|	Notification Field	            |	msdyn_notificationfield	                                |	Read	                    |	Global	|
|	Notification Template	        |	msdyn_notificationtemplate	                            |	Read	                    |	Global	|
|	Notification Field <br>(Deprecated)</br>	|	msdyn_consoleapplicationnotificationfield	|	Read	                    |	Global	|
|	Notification Template <br>(Deprecated)</br>	|	msdyn_consoleapplicationnotificationtemplate	|	Read	                |	Global	|
|	Omnichannel Queue (deprecated)	|	msdyn_omnichannelqueue	                                    |	Read	                |	Global	|
|	Omnichannel Configuration    	|	msdyn_omnichannelconfiguration	                            |	Read	                |	Global	|
|	Omnichannel Personalization	    |	msdyn_omnichannelpersonalization	                  |	Create, Delete, Read, Update 	|	Basic	|
|	Ongoing conversation <br>(Deprecated)</br>	|	msdyn_liveconversation	                    |	Create	                    |	Basic	|
|		                                        |	                                            |	Read, Share	                |	Global	|
|	                                        	|	                                        	|	Append, Append To, Update	|	Local	|
|		                                        |		                                        |	Assign	                    |	Deep	|
|	Pane tool configuration	                    |	msdyn_panetoolconfiguration	                |	Read	                    |	Global	|
|	Parameter (Deprecated)	                    |	msdyn_consoleapplicationtemplateparameter	|	Read	                    |	Global	|
|	Persona Security Role Mapping             	|	msdyn_personasecurityrolemapping	        |	Read                    	|	Global	|
|	Personal quick reply	                    |	msdyn_personalmessage     	|	Append, Append To, Create, Delete, Read, Update	|	Basic	|
|	Personal sound setting	                    |	msdyn_Personalsoundsetting 	|	Append, Append To, Create, Delete, Read, Update	|	Basic	|
|	PluginAssembly	                            |	PluginAssembly	                        |	Read	                        |	Global	|
|	PluginType                                	|	PluginType                            	|	Read                        	|	Global	|
|	Presence                                	|	msdyn_presence	                        |	Read	                        |	Global	|
|	Productivity pane configuration            	|	msdyn_paneconfiguration	                |	Read	                        |	Global	|
|	Provisioning State	                        |	msdyn_ocprovisioningstate	            |	Read                        	|	Global	|
||||


|	Table name                            |	Table unique name	                  |	Privilege name                |	Recommended access level	|
|	   -----                              |------	                              |	------                          |	  ---              	|
|	Queue	                                    |	Queue	                                |	Append, Read	                |	Global	|
|	Quick reply	                                |	msdyn_cannedmessage	                    |	Read                        	|	Global	|
|	Rating Model                            	|	RatingModel                            	|	Read	                        |	Global	|
|	Rating Value	                            |	RatingValue	                            |	Read	|	Global	|
|	Recording	                                |	msdyn_ocrecording	                    |	Read	|	Global	|
|	Role	                                    |	Role	                                |	Read	|	Global	|
|	Routing configuration                     	|	msdyn_routingconfiguration            	|	Read	|	Global	|
|	Routing configuration step                	|	msdyn_routingconfigurationstep        	|	Read	|	Global	|
|	Rule Item	                                |	msdyn_ocruleitem	                    |	Read	|	Global	|
|	Scenario	                                |	msdyn_scenario                        	|	Read	|	Global	|
|	SdkMessage                                	|	SdkMessage	                            |	Read	|	Global	|
|	SdkMessageProcessingStep                	|	SdkMessageProcessingStep               	|	Read	|	Global	|
|	SdkMessageProcessingStepImage	            |	SdkMessageProcessingStepImage	        |	Read	|	Global	|
|	Search Configuration	                    |	msdyn_searchconfiguration	            |	Read	|	Global	|
|	Self service                            	|	msdyn_visitorjourney	                |	Read	|	Global	|
|	Sentiment Analysis                        	|	msdyn_sentimentanalysis                	|	Read	|	Global	|
|	Service Endpoint	                        |	ServiceEndpoint	                        |	Read	|	Global	|
|	Session event	                            |	msdyn_sessionevent                     	|	Read	|	Global	|
|	Session Template	                        |	msdyn_sessiontemplate                	|	Read	|	Global	|
|	Session Characteristic                    	|	msdyn_ocsessioncharacteristic	        |	Read	|	Global	|
|	Session participant	                        |	msdyn_sessionparticipant	            |	Read	|	Global	|
|	Session Templates (Deprecated)            	|	msdyn_consoleapplicationsessiontemplate	|	Read	|	Global	|
|	SharePoint Data                            	|	SharePointData                        	|	Create, Read, Update	|	Global	|
|	SharePointDocument	                        |	SharePointDocument                    	|	Read	|	Global	|
|	Skill finder model                        	|	msdyn_ocskillidentmlmodel            	|	Read	|	Global	|
|	Solution	                                |	Solution	                            |	Read	|	Global	|
|	Sound notification setting                  |	msdyn_soundnotificationsetting	        |	Append, Append To, Read	|	Global	|
|	System User                        	        |	User	                                |	Read	|	Local	|
|	Tag	                                        |	msdyn_octag	                  |	Append, Append To, Create, Delete, Read, Update	|	Global	|
|	Template Parameter	                        |	msdyn_templateparameter                	|	Read	|	Global	|
|	Template Tag (Deprecated)	                |	msdyn_templatetags                    	|	Read	|	Global	|
|	Training data import configuration	        |	msdyn_ocsitdimportconfig	            |	Read	|	Global	|
|	Training record	                            |	msdyn_ocsitrainingdata                	|	Read	|	Global	|
|	Transcript                                	|	msdyn_transcript	                    |	Read	|	Global	|
|	UR notification template	                |	msdyn_urnotificationtemplate	        |	Read	|	Global	|
|	UR Notification Template Mapping	        |	msdyn_urnotificationtemplatemapping	    |	Read	|	Global	|
|	User settings	                            |	msdyn_usersetting	         |	Append, Append To, Create, Delete, Read, Update	|	Global	|
|	Workstream capacity profile	            |	msdyn_liveworkstreamcapacityprofile	    |	Read	                |	Local	|
|	Workstream                                	|	msdyn_liveworkstream	                |	Append, Append To, Read	|	Global	|
|	                                        	|		                                    |	Assign, Share	        |	Basic	|
||||

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Manage users for unified routing](users-user-profiles.md)  
[Add custom security roles in Customer Service](role-persona-mapping.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]  