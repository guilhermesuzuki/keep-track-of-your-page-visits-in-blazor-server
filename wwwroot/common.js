var website = {
    pages: {
        view: () => {
            var href = encodeURIComponent(location.href);
            var referrer = encodeURIComponent(document.referrer);
            var url = `/views?href=${href}&referrer=${referrer}&v=${Math.random()}`;
            $.get(url);
        },
    },
};