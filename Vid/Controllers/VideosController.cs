using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.Provider;
using Vid.Models;

namespace Vid.Controllers
{
    public class VideosController : ApiController
    {
        private VideoDb _db;

        public VideosController()
        {
            this._db = new VideoDb();
            _db.Configuration.ProxyCreationEnabled = false;
        }
        // GET: api/Video
        public IEnumerable<Video> GetAllVideos()
        {
            return this._db.Videos;
        }

        // GET: api/Video/5
        public Video Get(int id)
        {
            var video = this._db.Videos.Find(id);
            if (video == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return video;
        }

        // POST: api/Video
        public HttpResponseMessage Post(Video video)
        {
            if (!ModelState.IsValid) return Request.CreateResponse(HttpStatusCode.BadRequest);
            this._db.Videos.Add(video);
            this._db.SaveChanges();

            var response = Request.CreateResponse(HttpStatusCode.Created , video);
            response.Headers.Location = new Uri(Url.Link("DefaultApi" , new { id = video.Id }));
            return response;
        }

        
        public HttpResponseMessage Put(int id, Video video)
        {
            if (ModelState.IsValid && id == video.Id)
            {
                this._db.Entry(video).State = EntityState.Modified;
                try
                {
                    this._db.SaveChanges();
                }
                catch (Exception)
                {
                    return Request.CreateResponse(HttpStatusCode.NotModified);
                }
                return Request.CreateResponse(HttpStatusCode.Created, video);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Video/5
        public HttpResponseMessage Delete(int id)
        {
            var video = this._db.Videos.Find(id);
            if (video == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            this._db.Videos.Remove(video);

            try
            {
                this._db.SaveChanges();
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
                
            }

            return Request.CreateResponse(HttpStatusCode.OK , video);
        }
    }
}
