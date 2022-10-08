package application.rest;

import javax.print.attribute.standard.Media;
import javax.ws.rs.Path;

import javax.ws.rs.core.Application;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;

@Path("/")
public class LibertyRestEndpoint extends Application {
    private final static String[] headers_to_propagate = {
        "x-request-id",
        "x-ot-span-context",
    };

    private String getJsonResponse (String productId, int starsReviewer1, int starsReviewer2) {

    }

    @GET
    @Path("/health")
    public Response health() {
        return Response.ok().type(MediaType.APPLICATION_JSON).entity("{\"status\": \"Reviews is healthy\"}").build();
    }
}