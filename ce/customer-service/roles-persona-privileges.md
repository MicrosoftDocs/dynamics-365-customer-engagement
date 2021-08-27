---
title: "Roles, persona, and privileges | MicrosoftDocs"
description: "Information about how security roles can be mapped to persona and privileges."
ms.date: 08/31/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
---

# Roles, persona, and privileges

This topic lists the roles, persona, and privileges for the agent, supervisor, and administrator.
More information: [Manage personas](role-persona-mapping.md#manage-personas) 

## Role: Administrator

|	Table name	|	Table or metadata	|	Privilege name	|	Recommended depth	|
|	   -----    |------	                |	------          |	  ---  	|
|	Activity	                          |	Activity	                          |	Append, AppendTo, Delete, Update	                      |	Local	|
|		                                  |		                                  |	Assign	                                                  |	Deep	|
|		                                  |		                                  |	Create	                                                  |	Basic	|
|		                                  |		                                  |	Read, Share	                                              |	Global	|
|	AdminAppState	                      |	msdyn_adminappstate	                  |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Agent Status history	              |	msdyn_agentstatushistory	          |	Create, Delete, Read, Update                              |	Global	|
|	AI Configuration	                  |	msdyn_aiconfiguration	              |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	AI Model	                          |	msdyn_aimodel	                      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	AI Template	                          |	msdyn_aitemplate	                  |	Read	                                                  |	Global	|
|	App Module	                          |	AppModule	                          |	Read, Update	                                          |	Global	|
|	App Profile	                          |	msdyn_appconfiguration	              |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	App Configuration	                  |	AppConfig	                          |	Read	                                                  |	Global	|
|	App Parameter Definition<br> (Deprecated)</br> | msdyn_consoleappparameterdefinition |	Append, AppendTo, Create, Delete, Read, Update 	  |	Global	|
|	Application Extension	              |	msdyn_applicationextension	          |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Application Tab Template	          |	msdyn_applicationtabtemplate	      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Application Tab Template <br>(Deprecated)</br> |	msdyn_consoleapplicationtemplate | Append, AppendTo, Create, Delete, Read, Update     |	Global	|
|	Application Type (Deprecated)	      |	msdyn_consoleapplicationtype	      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Assignment Configuration	          |	msdyn_assignmentconfiguration	      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Assignment Configuration Step	      |	msdyn_assignmentconfigurationstep     |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Audio File	                          |	msdyn_soundfile	                      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Bookable Resource	                  |	BookableResource	                  |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
| Bookable Resource Capacity<br>Profile</br>| msdyn_bookableresourcecapacityprofile | Append, AppendTo, Assign, Create, Delete, Read, Share, Update| Global |
|	Bookable Resource Characteristic	  |	BookableResourceCharacteristic	      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Capacity Profile	                  |	msdyn_capacityprofile	              |	Append, AppendTo, Assign, Create, Delete, Read, Share, Update| Global |
|	channel	                              |	msdyn_channel	                      |	Append, AppendTo, Create, Delete, Read, Update            |	Global	|
|	Channel Provider	                  |	msdyn_channelprovider	              |	Create, Delete, Read, Update	                          |	Global	|
|	Channel Configuration	              |	msdyn_occhannelconfiguration	      |	Read, Update	                                          |	Global	|
|	Channel Integration Framework <br>v1.0 Provider</br> |	msdyn_ciprovider      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Channel State Configuration	          |	msdyn_occhannelstateconfiguration	  |	Read	                                                  |	Global	|
|	Characteristic	                      |	Characteristic	                      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Characteristic mapping	              |	msdyn_ocsitdskill	                  |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Charts	                              |	SavedQueryVisualizations	          |	Read	                                                  |	Global	|
|	Columns	                              |	Attribute	                          |	Update	                                                  |	Global	|
|	Context item value	                  |	msdyn_ocliveworkitemcontextitem	      |	Append, Create, Delete, Read, Update	                  |	Global	|
|	Context variable	                  |	msdyn_ocliveworkstreamcontextvariable |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Conversation Capacity profile	      |	msdyn_ocliveworkitemcapacityprofile  | Append, AppendTo, Assign, Create, Delete, Read, Share, Update |Global|
|	Conversation Characteristic	          |	msdyn_ocliveworkitemcharacteristic	  |	Append, AppendTo, Create, Delete, Read, Update            |	Global	|
|	Conversation Sentiment	              |	msdyn_ocliveworkitemsentiment	      |	Create, Delete, Read, Update	                          |	Global	|
|	Custom messaging account	          |	msdyn_ocbotchannelregistration	      |	Append, AppendTo, Create, Delete, Read, Update  	      |	Global	|
|	Customization	                      |	Customization	                      |	Publish, Read, Update	                                  |	Global	|
|	Decision contract	                  |	msdyn_decisioncontract	              |	Append, AppendTo, Assign, Create, Delete, Read, Share, Update |	Global	|
|	Decision rule set	                  |	msdyn_decisionruleset	              |	Append, AppendTo, Assign, Create, Delete, Read, Share, Update |	Global	|
|	Deprecated Workstream Entity<br> Configuration</br>	 |	msdyn_entityconfig	  |	Append, AppendTo, Create, Delete, Read, Update	      |	Global	|
|	Entity	                              |	msdyn_entityroutingconfiguration	  |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Entity Routing Context	              |	msdyn_cdsentityengagementctx	      |	Create, Delete, Read, Update	         |	Global	|
|	Forms	                              |	SystemForm	                          |	Read	                                  |	Global	|
|	Geo Location Provider	              |	msdyn_oc_geolocationprovider	      |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	KPI Event Definition	              |	msdyn_kpieventdefinition	          |	Read	                                  |	Global	|
|	Language	                          |	msdyn_oclanguage	                  |	Read, AppendTo	                          |	Global	|
|	Live work item event	              |	msdyn_liveworkitemevent	              |	Create, Delete, Read, Update		      |	Global	|
|	Live Work Item Participant<br>(Deprecated)</br> |	msdyn_ocliveworkitemparticipant	  |	Create, Delete, Read, Update	  |	Global	|
|	Localization	                      |	msdyn_oclocalizationdata	          |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Masking Rule	                      |	msdyn_maskingrule	                  |	Create, Delete, Read, Update	            |	Global	|
|	Master Entity Routing<br>Configuration</br> |	msdyn_masterentityroutingconfiguration	  |	Create	                  | Local	|
|		                                  |		                                  |	Append, AppendTo, Assign, Read, Share, Update	          |	Global	|
|		                                  |		                                  |	Delete	                                  |	Deep	|
|		                                  |		                                  |	Create	                                  |	Local	|
|	Message	                              |	msdyn_ocsystemmessage	              |	Append, AppendTo, Create, Delete, Read, Update	       |	Global	|
|	Model training details	              |	msdyn_ocsimltraining	              |	Append, AppendTo, Create, Delete, Read, Update	             |	Global	|
|	Notification Field	                  |	msdyn_notificationfield	              |	Append, AppendTo, Create, Delete, Read, Update	          |	Global	|
|	Notification Template	              |	msdyn_notificationtemplate	          |	Append, AppendTo, Create, Delete, Read, Update	  |	Global	|
|	Notification Field (Deprecated)	      |	msdyn_consoleapplicationnotificationfield	 | Append, AppendTo, Create, Delete, Read, Update  | Global	|
|	Notification Template <br>(Deprecated)</br>	  |	msdyn_consoleapplicationnotificationtemplate | Append, AppendTo, Create, Delete, Read, Update |Global	|
|	Omnichannel Queue (deprecated)	      |	msdyn_omnichannelqueue	              |	Append, AppendTo, Assign, Create, Delete, Read, Update	   |	Global	|
|	Omnichannel Configuration	          |	msdyn_omnichannelconfiguration	      |	Append, AppendTo, Read, Update	          |	Global	|
|	Omnichannel Personalization	          |	msdyn_omnichannelpersonalization	  |	Create, Delete, Read, Update	          |	Global	|
|	Ongoing conversation (Deprecated)	  |	msdyn_liveconversation	              |	Append, AppendTo, Update	              |	Local	|
|		                                  |		                                  |	Assign	                                  |	Deep	|
|		                                  |		                                  |	Create	                                  |	Basic	|
|		                                  |		                                  |	Read, Share	                              |	Global	|
|	Operating Hour	                      |	msdyn_operatinghour	                  |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Pane tool configuration	              |	msdyn_panetoolconfiguration           |	Read	                                  |	Global	|
|	Parameter (Deprecated)	              |	msdyn_consoleapplicationtemplateparameter	| Append, AppendTo, Create, Delete, Read, Update |	Global	|
|	Persona Security Role Mapping	      |	msdyn_personasecurityrolemapping	  |	Append, AppendTo, Create, Delete, Read, Update	 |	Global	|
|	Personal quick reply	              |	msdyn_personalmessage	              |	Append, AppendTo, Create, Delete, Read, Update	 |	Basic	|
|	Personal sound setting	              |	msdyn_Personalsoundsetting	          |	Append, AppendTo, Create, Delete, Read, Update	 |	Basic	|
|	PluginAssembly	                      |	PluginAssembly	                      |	Read	                                  |	Global	|
|	PluginType	                          |	PluginType	                          |	Read	                                  | Global	|
|	Power BI Configuration	              |	msdyn_analytics	                      |	Create, Delete, Read, Update	          |	Global	|
|	Presence	                          |	msdyn_presence	                      |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Productivity pane configuration	      |	msdyn_paneconfiguration	              |	Read	                                  |	Global	|
|	Provisioning State	                  |	msdyn_ocprovisioningstate	          |	Append, AppendTo, Create, Delete, Read, Update	        |	Global	|
|	Publisher	                          |	Publisher	                          |	Read	                                  |	Global	|
|	Publisher Address	                  |	PublisherAddress	                  |	Read	                                  |	Global	|
|	Query	                              |	Query	                              |	Read, Update	                          |	Global	|
|	Queue	                              |	Queue	                              |	Append, AppendTo, Assign, Create, Delete, Read, Update   |	Global	|
|	Quick reply	                          |	msdyn_cannedmessage	                  |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Rating Model	                      |	RatingModel	                          |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Rating Value	                      |	RatingValue	                          |	Append, AppendTo, Create, Delete, Read, Update      |	Global	|
|	Recording	                          |	msdyn_ocrecording	                  |	Append, AppendTo, Create, Delete, Read, Update      |	Global	|
|	Relationship	                      |	Relationship	                      |	Update	                                  |	Global	|
|	Role	                              |	Role	                              |	AppendTo, Assign, Read	                   |	Global	|
|	Routing configuration	              |	msdyn_routingconfiguration	          |	Append, AppendTo, Create, Delete, Read, Update 	    |	Global	|
|	Routing configuration step	          |	msdyn_routingconfigurationstep	      |	Append, AppendTo, Create, Delete, Read, Update 	    |	Global	|
|	Rule Item	                          |	msdyn_ocruleitem	                  |	Append, AppendTo, Create, Delete, Read, Update 	    |	Global	|
|	Rulesetentitymapping	              |	msdyn_rulesetdependencymapping        |	Append, AppendTo, Assign, Create, Delete, Read, Update       |	Global	|
|	Scenario	                          |	msdyn_scenario	                      |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	SdkMessage	                          |	SdkMessage	                          |	Read	                                  |	Global	|
|	SdkMessageProcessingStep	          |	SdkMessageProcessingStep	          |	Read	                                  |	Global	|
|	SdkMessageProcessingStepImage	      |	SdkMessageProcessingStepImage         |	Read	                                  |	Global	|
|	Search Configuration	              |	msdyn_searchconfiguration	          |	Create, Delete, Read, Update	          |	Global	|
|	Self service	                      |	msdyn_visitorjourney	              |	Read	                                  |	Global	|
|	Sentiment Analysis	                  |	msdyn_sentimentanalysis	              |	Read, Update	                          |	Global	|
|	Service Endpoint	                  |	ServiceEndpoint	                      |	Read	                                  |	Global	|
|	Session event	                      |	msdyn_sessionevent	                  |	Create, Delete, Read, Update	          |	Global	|
|	Session Template	                  |	msdyn_sessiontemplate	              |	Append, AppendTo, Create, Delete, Read, Update 	       |	Global	|
|	Session Characteristic	              |	msdyn_ocsessioncharacteristic         |	Append, AppendTo, Create, Delete, Read, Update 	    |	Global	|
|	Session participant	                  |	msdyn_sessionparticipant	          |	Create, Delete, Read, Update 	  |	Global	|
|	Session Templates (Deprecated)	 |	msdyn_consoleapplicationsessiontemplate	  |	Append, AppendTo, Create, Delete, Read, Update 	      |	Global	|
|	SharePoint Data	                      |	SharePointData	                      |	Create, Read, Update 	                              |	Global	|
|	SharePointDocument	                  |	SharePointDocument	                  |	Read	                                  |	Global	|
|	Skill finder model	                  |	msdyn_ocskillidentmlmodel	          |	Append, AppendTo, Create, Delete, Read, Update      |	Global	|
|	Solution	                          |	Solution	                          |	Read, Update	                                  |	Global	|
|	Sound notification setting	          |	msdyn_soundnotificationsetting	      |	Append, AppendTo, Create, Delete, Read, Update	     |	Global	|
|	System User	                          |	User	                              |	Append, AppendTo, Create, Read, Update	  |	Global	|
|	Table	                              |	Entity	                              |	Update	                                  |	Global	|
|	Tag	                                  |	msdyn_octag	                          |	Append, AppendTo, Create, Delete, Read, Update      |	Global	|
|	Template Parameter	                  |	msdyn_templateparameter	              |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Template Tag (Deprecated)	          |	msdyn_templatetags	                  |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Training data import configuration	  |	msdyn_ocsitdimportconfig	          |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Training record	                      |	msdyn_ocsitrainingdata	              |	ApAppend, AppendTo, Create, Delete, Read, Updatepend	   |	Global	|
|	Transcript	                          |	msdyn_transcript	                  |	Append, AppendTo, Create, Delete, Read, Update	    |	Global	|
|	Unified routing diagnostic	          |	msdyn_unifiedroutingdiagnostic	      |	Delete, Read, Update	                                  |	Global	|
|	Unified routing run	                  |	msdyn_unifiedroutingrun	              |	Delete, Read	                                  |	Global	|
|	UR notification template	          |	msdyn_urnotificationtemplate	      |	Append, AppendTo, Create, Delete, Read, Update    |	Global	|
|	UR Notification Template <br>Mapping</br>|	msdyn_urnotificationtemplatemapping	| Append, AppendTo, Create, Delete, Read, Update  | Global  |
|	User Setting	                      |	msdyusd_usersettings                  |	Append, AppendTo, Read, Update	                  |	Global	|
|	User settings	                      |	msdyn_usersettin                      |	Append, AppendTo, Create, Delete, Read, Update	  |	Global	|
|	Work stream capacity profile	      |	msdyn_liveworkstreamcapacityprofile	  |	Append, AppendTo, Assign, Create, Delete, Read, Share, Update  |Global	|
|	Workstream	                          | msdyn_liveworkstream	              |	Append, AppendTo, Assign, Create, Delete, Read, Share, Update  | Global	|
| | | | 


## Role: Supervisor

## Role: Agent

| Entity name	| Entity or Metadata | Privilege name	| Depth or Level    |
|---------------|--------------------|------------------| --------          |
| Solution      | Solution           |   Read           | Global            |



### See also

[Overview of unified routing](overview-unified-routing.md)  
[Manage users for unified routing](users-user-profiles.md)  
[Add custom security roles in Customer Service](role-persona-mapping.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]  