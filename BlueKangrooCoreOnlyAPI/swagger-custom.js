(function () {
    const csrfTokenEndpoint = '/api/AppToken/GetAntiforgeryToken';

    fetch(csrfTokenEndpoint)
        .then(response => response.json())
        .then(data => {
            const token = data.token;
            if (token) {
                // Add request interceptor to include the CSRF token
                const requestInterceptor = (req) => {
                    req.headers["X-CSRF-TOKEN"] = token;
                    return req;
                };

                SwaggerUIBundle({
                    url: "/swagger/v1/swagger.json",
                    dom_id: "#swagger-ui",
                    requestInterceptor: requestInterceptor,
                });
            }
        })
        .catch(error => console.error("Error fetching CSRF token:", error));
})();
