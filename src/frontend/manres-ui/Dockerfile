FROM node:20 AS build
WORKDIR /app
COPY src/frontend/manres-ui/package*.json ./
RUN npm install
COPY src/frontend/manres-ui .
RUN npm run build

FROM nginx:1.27-alpine
COPY src/frontend/manres-ui/nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist /usr/share/nginx/html
EXPOSE 80
