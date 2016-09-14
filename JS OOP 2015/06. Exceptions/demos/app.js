try {
    throw{
        message:'An exception obj thrown',
        description:'This is not a good way to throw exceptions'
    };
} catch (error) {
    console.log(error.message);
    console.log(error.description);
}