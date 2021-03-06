﻿## 1.6.0
 - Enables label sharding support (according to feature definition in https://github.com/SDVentures/Contour/issues/27):
   - an endpoint should be able to connect to several broker nodes (with different connection strings) simultaneously;
   - an endpoint should receive messages from all broker nodes (connection strings) specified in the configuration element;
   - an endpoint should send messages to only one broker node (connection string) which should be selected based on a list of supported algorithms (Round Robin);
   - the connection string property specified on the endpoint or incoming/outgoing configuration element should be able to define a list of broker URLs;


## 1.5.0
 - An issue https://github.com/SDVentures/Contour/issues/25 has been fixed. A new correlation id will always be used for outgoing requests.

## 1.4.1
 - NuGet package image added.

## 1.4.0
 - BusProcessingContext used by operators now has reference to used IBusContext.

## 1.3.0
 - Separate connection for each sender and receiver (connection per label) feature introduced. Connection configuration per label (connection string and reuse flag) feature introduced. Connection reuse property switched to bool? due to Maybe<bool>(false) bug.

## 1.2.2
 - QoS & PL settings can now be overriden if no endpoint configuration provided.

## 1.2.1
 - QoS & PL default settings are now preserved if not specified in configufation.

## 1.2.0
 - Incoming message listener QoS and parallelism level configuration added.

## 1.1.1
 - Deleted destructor and overloaded Dispose method to leave only one option for endpoint deletion.

## 1.1.0
 - Added ability to configure a TTL of the fault queue and the maximum queue length of the fault queue.

## 1.0.2
 - Fixed OutOfRangeException when Request/Reply timeouts occur.

## 1.0.1
 - Specified only lower bounds of nuget package dependencies.

## 1.0.0
 - Initial commit.
