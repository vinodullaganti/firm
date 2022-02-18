import moment from "moment";

export const getCurrentYear = () => {
    return moment().format('YYYY');
}

export const formatJoiningDate = (dateTime) => {
    return dateTime ? moment(dateTime).format("MMM Do YY") : '';
}

export const formatDateOfBirth = (dateTime) => {
    return dateTime ? moment(dateTime).format('MMM DD') : '';
}

export const formatHoliday = (dateTime) => {
    return dateTime ? moment(dateTime).format('DD MMMM YYYY') : '';
}

export const getDay = (dateTime) => {
    return dateTime ? moment(dateTime).format('dddd') : '';
}