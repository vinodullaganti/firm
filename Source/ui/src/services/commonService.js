export const getCurrentYear = ()=>{
    return new Date().getFullYear();
}

//Friday, January 14, 2022
export const formatDateTime = (dateTime)=>{
    debugger;
    const formatter = new Intl.DateTimeFormat('en-US', 
        { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' });
    
    return formatter.format(new Date(dateTime));

}