# ESFA-DC-JobContext

## Introduction

Provides the core message interface, implementation and DTO for the Job Context Message. The Job Context Message provides context information regarding the current job, and is serialised/deserialised onto the Azure Service Bus. The implementation contains the following fields:
- JobId
- SubmissionDateTimeUTC
- Topics
- TopicPointer
- KeyValuePairs

##### JobId

The unique Job Identifier for the job. A long.

##### SubmissionDateTimeUTC

The UTC date & time of the job submission (as recorded from the front end submission).

##### Topics

An array of topics that are to be executed as part of the job.

##### TopicPointer

An integer pointing at the next Topic index.

##### KeyValuePairs

A dictionary of data specific to the job. Keys are defined in JobContextMessageKey.

## Usage

Interfaces provides the interface definitions for the message, task and topic classes. The JobContextMessageKey provides the keys (as an enum) for the KeyValuePairs dictionary.

All interfaces are implemented in the main package along with DTO versions which use concrete data types.