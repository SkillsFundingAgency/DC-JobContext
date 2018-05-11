namespace ESFA.DC.JobContext.Interface
{
    public enum JobContextMessageKey
    {
        /// <summary>
        /// The UkPrn number. (int)
        /// </summary>
        UkPrn,

        /// <summary>
        /// The name of the container containing the file to process. (string)
        /// </summary>
        Container,

        /// <summary>
        /// The name of the file to process. (string)
        /// </summary>
        Filename,

        /// <summary>
        /// The size of the file in bytes. (long)
        /// </summary>
        FileSizeInBytes,

        /// <summary>
        /// The username who started the operation. (string)
        /// </summary>
        Username,

        /// <summary>
        /// The *Key* of the serialised valid learn ref numbers in storage. (string)
        /// </summary>
        ValidLearnRefNumbers,

        /// <summary>
        /// The number of valid learners. (long)
        /// </summary>
        ValidLearnRefNumbersCount,

        /// <summary>
        /// The *Key* of the serialised invalid learn ref numbers in storage. (string)
        /// </summary>
        InvalidLearnRefNumbers,

        /// <summary>
        /// The number of invalid learners. (long)
        /// </summary>
        InvalidLearnRefNumbersCount
    }
}
